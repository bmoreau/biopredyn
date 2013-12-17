## @package biopredyn
## @author: $Author$
## @date: $Date$
## @copyright: $Copyright: [2013] BioPreDyn $
## @version: $Revision$

import libsedml
import libsbml
from sympy import *
import variable, parameter

class DataGenerator:
  ## @var id
  # A unique identifier for this object.
  ## @var math
  # A SymPy expression.
  ## @var name
  # Name of this object.
  ## @var parameters
  # A list of Parameter objects.
  ## @var variables
  # A list of Variable objects.
  
  ## Constructor.
  # @param self The object pointer.
  # @param data_generator A SED-ML dataGenerator element.
  # @param workflow A WorkFlow object.
  def __init__(self, data_generator, workflow):
    self.id = data_generator.getId()
    self.name = data_generator.getName()
    # Parse the input data_generator object for parameters
    self.parameters = []
    for p in data_generator.getListOfParameters():
      self.parameters.append(parameter.Parameter(p))
    # Parse the input data_generator object for variables
    self.variables = []
    for v in data_generator.getListOfVariables():
      self.variables.append(variable.Variable(v, workflow))
    self.math = self.parse_math_expression(data_generator.getMath())
  
  ## String representation of this. Displays it as a hierarchy.
  # @param self The object pointer.
  # @return A string representing this as a hierarchy.
  def __str__(self):
    tree = "  |-dataGenerator id=" + self.id + " name=" + self.name + "\n"
    tree += "    |-listOfParameters\n"
    for p in self.parameters:
      tree += str(p)
    tree += "    |-listOfVariables\n"
    for v in self.variables:
      tree += str(v)
    return tree
  
  ## Getter. Returns self.id.
  # @param self The object pointer.
  # @return self.id
  def get_id(self):
    return self.id
  
  ## Getter. Returns self.math.
  # @param self The object pointer.
  # @return self.math
  def get_math(self):
    return self.math
  
  ## Getter. Returns self.name.
  # @param self The object pointer.
  # @return self.name
  def get_name(self):
    return self.name
  
  ## Evaluate the values encoded by this and returned them as a 1-dimensional
  # array of numerical values.
  # @param self The object pointer.
  # @return results A 1-dimensional array of numerical values.
  def get_values(self):
    # The number of time points to be considered must be known
    # It is assumed that all the variables have the same number of time points
    num_time_points = self.variables[0].get_task().get_simulation().get_number_of_points()
    results = []
    # Initialization 
    for i in range(num_time_points):
      results.append(self.math)
    # SymPy substitution - variables
    for v in self.variables:
      id = v.get_id()
      values = v.get_values()
      for n in range(num_time_points):
        results[n] = results[n].subs(id, values[n])
    # SymPy substitution - parameters
    for p in self.parameters:
      id = p.get_id()
      for n in range(num_time_points):
        results[n] = results[n].subs(id, p.get_value())
    return results
  
  ## Transform the input MathML mathematical expression into a SymPy
  # expression.
  # @param self The object pointer.
  # @param mathml A MathML expression.
  # @return math A SymPy expression.
  def parse_math_expression(self, mathml):
    math = sympify(libsbml.formulaToString(mathml))
    return math