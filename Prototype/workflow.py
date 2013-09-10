## @package biopredyn
## @author: $Author$
## @date: $Date$
## @copyright: $Copyright: [2013] BioPreDyn $
## @version: $Revision$

import sys

# FIXME: libsbmlsim should be installed in PYTHONPATH
sys.path.append('/usr/local/share/libsbmlsim/python/')

import libsedml
import COPASI
import libsbmlsim
from matplotlib import pyplot as plt
import numpy as np
import model, result, task

## Class for COPASI-based work flows using COPASI as main simulation engine.
class CopasiFlow:
  ## @var address
  # Address of the SED-ML file associated with the object.
  ## @var sedml
  # An SED-ML document.
  ## @var series
  # A time series resulting from a COPASI simulation run.
  
  ## Constructor.
  # @param self The object pointer.
  # @param file Address of the SED-ML file to be read.
  def __init__(self, file):
    self.address = file
    reader = libsedml.SedReader()
    self.sedml = reader.readSedML(file)
  
  ## Runs the uniformTimeCourse encoded in self.sedml, if it exists.
  # COPASI is used as simulation engine; stores the resulting time series into
  # self.timeseries
  def run(self):
    # Parse the list of tasks in the input file
    for t in self.sedml.getListOfTasks():
      model_source = self.sedml.getModel(t.getModelReference()).getSource()
      # Import the model to COPASI
      cop_datamodel = COPASI.CCopasiDataModel()
      cop_datamodel.importSBML(model_source)
      # Import simulation
      sed_simulation = self.sedml.getSimulation(t.getSimulationReference())
      # Case where the task is a uniform time course
      if ( sed_simulation.getElementName() == "uniformTimeCourse" ):
        cop_task = cop_datamodel.addTask(COPASI.CCopasiTask.timeCourse)
        cop_problem = cop_task.getProblem()
        # Required parameters are set from values in the input SED-ML file
        cop_problem.setDuration( sed_simulation.getOutputEndTime() -
                         sed_simulation.getOutputStartTime() )
        cop_problem.setStepNumber(sed_simulation.getNumberOfPoints())
        cop_problem.setOutputStartTime(sed_simulation.getOutputStartTime())
        cop_problem.setTimeSeriesRequested(True)
        # Deterministic method is chosen
        # TODO: acquire it from KiSAO value in SED-ML file
        cop_task.setMethodType(COPASI.CCopasiMethod.deterministic)
        # Run
        cop_task.process(True)
        # Save the results
        self.series = cop_task.getTimeSeries()
      else:
        # TODO: case of a generic simulation element
        print("Something to be done with Simulation element here")

## Class for SED-ML generic work flows using libSBMLSim as main simulation
## engine.
class SedMLFlow:
  ## @var address
  # Address of the SED-ML file associated with the object.
  ## @var results
  # A list of results for the object simulation runs.
  ## @var sedml
  # A SED-ML document.
  ## @var tasks
  # A list of task elements.
  
  ## Constructor.
  # @param self The object pointer.
  # @param file Address of the SED-ML file to be read.
  def __init__(self, file):
    self.address = file
    reader = libsedml.SedReader()
    self.sedml = reader.readSedML(file)
    self.check()
    self.tasks = []
    # Parsing self.sedml for task elements
    for t in self.sedml.getListOfTasks():
      self.tasks.append(task.Task(t, self.sedml))
    self.results = []
  
  ## SED-ML compliance check function.
  # Check whether self.sedml is compliant with the SED-ML standard; if
  # not, boolean value false is returned and the first error code met by the
  # reader is printed; if yes, the method returns a pointer to the SED-ML model
  # instead.
  # @param self The object pointer.
  # @return self.sedml
  def check(self):
    if self.sedml.getNumErrors() > 0:
      print("Error code " + str(self.sedml.getError(0).getErrorId()) +
            " when opening file: " +
            str(self.sedml.getError(0).getShortMessage()))
      sys.exit(2)
    else:
      print("Document " + self.address + " is SED-ML compliant.")
      # check compatibility with SED-ML level 1
      print( str(self.sedml.checkCompatibility(self.sedml)) +
             " compatibility errors with SED-ML L1." )
      return self.sedml
  
  ## Runs the uniformTimeCourse encoded in self.sedml.
  # libSBMLSim is used as simulation engine.
  # @param self The object pointer.
  def run(self):
    # Parse the list of tasks in the input file
    for t in self.sedml.getListOfTasks():
      model_source = self.sedml.getModel(t.getModelReference()).getSource()
      # Import simulation
      sed_simulation = self.sedml.getSimulation(t.getSimulationReference())
      # Case where the task is a uniform time course
      if ( sed_simulation.getElementName() == "uniformTimeCourse" ):
        steps = sed_simulation.getNumberOfPoints()
        start = sed_simulation.getOutputStartTime()
        end = sed_simulation.getOutputEndTime()
        step = (end - start) / steps
        r = libsbmlsim.simulateSBMLFromFile(
            model_source,
            end,
            step,
            1,
            0,
            libsbmlsim.MTHD_RUNGE_KUTTA,
            0)
        self.results.append(
            result.LibSBMLSimResult(r))
  
  ## Plots all the results stored in self.results
  # @param self The object pointer.
  # @param interactive Boolean value stating whether the plots have to be
  #   drawn in interactive mode or not.
  def plot_all_results(self, interactive):
    for i in self.results:
      i.plot2D_all(interactive)