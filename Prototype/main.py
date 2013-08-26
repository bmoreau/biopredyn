#!/usr/bin/python

__author__     = "Bertrand Moreau"
__copyright__  = "Copyright 2013, BioPreDyn"
__credits__    = ["Bertrand Moreau"]
__license__    = "BSD"
__version__    = "0.1"
__maintainer__ = ["Bertrand Moreau"]
__email__      = "bertrand.moreau@thecosmocompany.com"
__status__     = "Alpha"

import getopt
import sys
import textwrap
import libsbml
import libsedml
import COPASI
import numpy as np
import matplotlib.pyplot as plt

COMMAND_SYNTAX_MESSAGE = 'python main.py /path/to/input/file [options]'

HELP_MESSAGE = "This program is a prototype for the BioPreDyn software suite developed within the scope of the BioPreDyn FP7 project; it applies an analysis pattern to an SBML model defining a biological system."

# Optional parameters.
HELP_OPTION = {
"help"    : [  "Display this help message."],
"cobra"   : [  "Open the input file using the cobrapy library."],
"copasi"  : [  "Open the input SED-ML file and execute its tasks using the Copasi library."],
"sbml"    : [  "Open the input file as an SBML model; SBML compliance will be checked."],
"sedml"   : [  "Open the input file as an SED-ML model; SED-ML compliance will be checked."],
}

HELP_KEYWORD_SIZE = 16   # Left column
HELP_WRAP_SIZE = 79   # Total. 79 is windows limit

# Display help information.
def PrintHelp():
  # General help message
  print " "
  lines = textwrap.wrap(HELP_MESSAGE, HELP_WRAP_SIZE)
  for line in lines:
    print line
  print " "
  
  # Command syntax
  print "Usage: "
  print (COMMAND_SYNTAX_MESSAGE)
  print " "
  print "List of available options: "
  
  # Optional arguments
  for arg in HELP_OPTION:
    PrintHelpArgument(arg, HELP_OPTION[arg])

# Display help information for the input option.
def PrintHelpArgument(arg, listHelpLines):
  firstLine = True
  # Go trough list of help line
  for helpline in listHelpLines:
    lines = textwrap.wrap(helpline, HELP_WRAP_SIZE - HELP_KEYWORD_SIZE)
    for line in lines:
      # First line: Print arg name.
      if firstLine:
        print ('--' + arg).ljust(HELP_KEYWORD_SIZE) + line
        firstLine = False
      else:
        print ''.ljust(HELP_KEYWORD_SIZE) + line
  print ""

# Check whether the input model file is compliant with the SBML standard; if
# not, boolean value false is returned and the first error code met by the
# reader is printed; if yes, the method returns a pointer to the SBML model
# instead.
def CheckSBML(file):
  reader = libsbml.SBMLReader()
  model = reader.readSBML(file)
  if model.getNumErrors() > 0:
    print("Error code " + str(model.getError(0).getErrorId()) +
          " when opening file: " + str(model.getError(0).getShortMessage()))
    sys.exit(2)
  else:
    print("Model " + model.getModel().getName() + " is SBML compliant.")
    # Check compatiblity with different versions of SBML
    print( str(model.checkL1Compatibility()) +
           " compatibility errors with SBML L1." )
    print( str(model.checkL2v1Compatibility()) +
           " compatibility errors with SBML L2v1." )
    print( str(model.checkL2v2Compatibility()) +
           " compatibility errors with SBML L2v2." )
    print( str(model.checkL2v3Compatibility()) +
           " compatibility errors with SBML L2v3." )
    print( str(model.checkL2v4Compatibility()) +
           " compatibility errors with SBML L2v4." )
    print( str(model.checkL3v1Compatibility()) +
           " compatibility errors with SBML L3v1." )
    return model

# Check whether the input model file is compliant with the SED-ML standard; if
# not, boolean value false is returned and the first error code met by the
# reader is printed; if yes, the method returns a pointer to the SED-ML model
# instead.
def CheckSedML(file):
  reader = libsedml.SedReader()
  doc = reader.readSedML(file)
  if doc.getNumErrors() > 0:
    print("Error code " + str(doc.getError(0).getErrorId()) +
          " when opening file: " + str(doc.getError(0).getShortMessage()))
    sys.exit(2)
  else:
    print("Document " + file + " is SED-ML compliant.")
    # Check compatiblity with SED-ML level 1
    print( str(doc.checkCompatibility(doc)) +
           " compatibility errors with SED-ML L1." )
    return doc

# Parse the input SED-ML file and run the tasks it contains using COPASI
def RunWithCopasi(file):
  sed_doc = CheckSedML(file)
  for m in sed_doc.getListOfModels():
    CheckSBML(m.getSource())

  # Parse the list of tasks in the input file
  for t in sed_doc.getListOfTasks():
    model_source = sed_doc.getModel(t.getModelReference()).getSource()
    # Import the model to COPASI
    cop_datamodel = COPASI.CCopasiDataModel()
    cop_datamodel.importSBML(model_source)
    # Import simulation
    sed_simulation = sed_doc.getSimulation(t.getSimulationReference())
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
      # TODO: Plot the results
      series = cop_task.getTimeSeries()
      x = np.linspace(sed_simulation.getOutputStartTime(),
                      sed_simulation.getOutputEndTime(),
                      num = sed_simulation.getNumberOfPoints() + 1)
      plt.plot(x, series.getConcentrationDataForIndex(1),
               x, series.getConcentrationDataForIndex(2),
               x, series.getConcentrationDataForIndex(3),
               x, series.getConcentrationDataForIndex(4))
      plt.show()
      plt.close()
    # Case where the task does not describe a uniform time course not available
    # in libSEDML yet
    else:
      print "Non existing in libSEDML yet."
  return

# main
try:
  opts, args = getopt.getopt(sys.argv[2:], "",
                             ['help', 'cobra', 'copasi', 'sbml', 'sedml'])
except getopt.error, msg:
  print( COMMAND_SYNTAX_MESSAGE )
  print( "Type main.py --help for more information" )
  print( msg )
  sys.exit(2)

for o, a in opts:
  print str(o)
  if o == "--help":
    PrintHelp()
    sys.exit(0)
  elif o == "--sbml":
    model = CheckSBML(sys.argv[1])
  elif o == "--sedml":
    model = CheckSedML(sys.argv[1])
  elif o == "--cobra":
    print("Something will happen with cobrapy here soon.")
  elif o == "--copasi":
    RunWithCopasi(sys.argv[1])