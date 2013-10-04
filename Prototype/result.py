## @package biopredyn
## @author: $Author$
## @date: $Date$
## @copyright: $Copyright: [2013] BioPreDyn $
## @version: $Revision$

import sys

# FIXME: libsbmlsim should be installed in PYTHONPATH
sys.path.append('/usr/local/share/libsbmlsim/python/')

import libsbmlsim
import COPASI
from matplotlib import pyplot as plt

## Base class for simulation results
class Result:
  ## @var result 
  # Pointer to the output of a simulation run.
  
  ## Constructor.
  # @param self The object pointer.
  # @param result The result of a simulation run.
  def __init__(self, result):
    self.result = result
  
  ## Getter. Returns self.result.
  # @param self The object pointer.
  # @return self.result
  def get_result(self):
    return self.result

## Derived class for libSBMLSim simulation runs.
class LibSBMLSimResult(Result):
  
  ## Returns a list containing all the quantity values for the input species
  ## over time.
  # @param self The object pointer.
  # @param species The species which quantity values are wanted. 
  # @return A list of quantity values for the input species over time.
  def get_quantities_per_species(self, species):
    quantities = []
    for i in range(self.result.getNumOfRows()):
      quantities.append(self.result.getSpeciesValueAtIndex(species, i))
    return quantities
  
  ## Returns the list of all time steps in self.result.
  # @param self The object pointer.
  # @return The list of time steps.
  def get_time_steps(self):
    time = []
    for i in range(self.result.getNumOfRows()):
      time.append(self.result.getTimeValueAtIndex(i))
    return time
  
  ## Plots all the time series stored in self.result on a single 2D plot
  # @param self The object pointer.
  # @param interactive Boolean value stating whether the plots have to be
  #   drawn in interactive mode or not.
  def plot2D_all(self, interactive):
    time = self.get_time_steps()
    if interactive:
      plt.ion()
    for i in range(self.result.getNumOfSpecies()):
      name = self.result.getSpeciesNameAtIndex(i)
      plt.plot(time, self.get_quantities_per_species(name), label=name)
    plt.legend()
    plt.show()
    plt.close()
  
  ## Write the content of self.result in a file at the input location
  # @param self The object pointer.
  # @param path Path to the folder where the output file will be written
  # (including the file name).
  def write(self, path):
    libsbmlsim.write_result(self.result, path)

## Derived class for COPASI simulation runs.
class CopasiResult:
  
  ## Returns a list containing all the quantity values for the input species
  ## over time.
  # @param self The object pointer.
  # @param species The species which quantity values are wanted. 
  # @return A list of quantity values for the input species over time.
  def get_quantities_per_species(self, species):
    quantities = []
    return quantities
  
  ## Returns the list of all time steps in self.result.
  # @param self The object pointer.
  # @return The list of time steps.
  def get_time_steps(self):
    time = []
    return time