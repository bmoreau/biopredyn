# coding=utf-8

## @package biopredyn
## @author: $Author$
## @date: $Date$
## @copyright: $Copyright: [2013] BioPreDyn $
## @version: $Revision$

import libsbmlsim
import libnuml
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

## Derived class for COPASI simulation runs.
class CopasiResult:
  
  ## Returns a list containing all the quantity values for the input species
  ## over time.
  # @param self The object pointer.
  # @param species The species which quantity values are wanted. 
  # @return A list of quantity values for the input species over time.
  def get_quantities_per_species(self, species):
    quantities = []
    # TODO
    return quantities
  
  ## Returns the list of all time steps in self.result.
  # @param self The object pointer.
  # @return The list of time steps.
  def get_time_steps(self):
    time = []
    # TODO
    return time

## Derived class for NUML formatted results
class NuMLResult(Result):
  
  ## Returns a list containing all the quantity values for the input species
  ## over time.
  # @param self The object pointer.
  # @param species The species which quantity values are wanted.
  # @param component Index of the ResultComponent to be considered; default 0.
  # @return A list of quantity values for the input species over time.
  def get_quantities_per_species(self, species, component=0):
    quantities = []
    component = self.result.getResultComponents().get(component)
    # TODO - The "get" problem in libnuml should be solved first.
    return quantities
  
  ## Returns the list of all time steps in self.result.
  # @param self The object pointer.
  # @return The list of time steps.
  def get_time_steps(self):
    time = []
    # TODO
    return time
  