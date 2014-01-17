# coding=utf-8

## @package biopredyn
## @author: $Author$
## @date: $Date$
## @copyright: $Copyright: [2013-2014] BioPreDyn $
## @version: $Revision$

from matplotlib import pyplot as plt
from mpl_toolkits.mplot3d import Axes3D

## Base class for data description.
class Data:
  ## @var id
  # A unique identifier.
  ## @var name
  # Name of this object.
  ## @var type
  # Type of output.
  
  ## Getter. Returns self.id.
  # @param self The object pointer.
  def get_id(self):
    return self.id
  
  ## Getter. Returns self.name.
  # @param self The object pointer.
  def get_name(self):
    return self.name
  
  ## Getter. Returns self.type.
  # @param self The object pointer.
  # @return self.type
  def get_type(self):
    return self.type

## Data-derived class for N-dimensional data set description.
class DataSet(Data):
  ## @var data_ref
  # ID of a DataGenerator object.
  ## @var label
  # A label for this.
  
  ## Overridden constructor.
  # @param self The object pointer.
  # @param dataset A SED-ML dataSet element.
  # @param workflow A WorkFlow object.
  def __init__(self, dataset, workflow):
    self.id = dataset.getId()
    self.label = dataset.getLabel()
    self.name = dataset.getName()
    self.type = dataset.getElementName()
    self.data_ref = workflow.get_data_generator_by_id(
      dataset.getDataReference())
  
  ## String representation of this. Displays it as a hierarchy.
  # @param self The object pointer.
  # @return A string representing this as a hierarchy.
  def __str__(self):
    tree = "      |-" + self.type + " id=" + self.id + " name=" + self.name
    tree += " dataReference=" + self.data_ref + "\n"
    return tree
  
  ## Getter. Returns self.label.
  # @param self The object pointer.
  # @return self.label
  def get_label(self):
    return self.label
  
  ## Returns the number of time points in self.data_ref.
  # @param self The object poitner.
  # @return The number of time points in self.data_ref.
  def get_number_of_points(self):
    return self.data_ref.get_number_of_points()
  
  ## Getter. Returns self.data_ref.
  # @param self The object pointer.
  # @return self.data_ref
  def get_data_ref(self):
    return self.data_ref
  
  ## Write the data encoded in this at the end of the input file; data is
  ## written as comma-separated values, as follows:
  ## self.name,0.23,2.56,2.1e-9,[...],5.23
  # @param self The object pointer.
  # @param file A writable .csv file.
  def write_as_csv(self, file):
    file.write(self.name + u',')
    values = self.data_ref.get_values()
    for v in values:
      file.write(str(v) + u',')
    file.write(u'\n')
  
  ## Write the data encoded in the input Dimension object; each data
  ## value is written in the composite value corresponding to its index.
  # @param self The object pointer.
  # @param dim A Dimension instance.
  def write_as_numl(self, dim):
    values = self.data_ref.get_values()
    for i in range(len(values)):
      comp = dim.get(i).createCompositeValue()
      comp.setIndexValue(self.name)
      value = comp.createAtomicValue()
      value.setValue(str(values[i]))

## Data-derived class for 2-dimensional data set description.
class Curve(Data):
  ## @var x_data_ref
  # ID of a DataGenerator object.
  ## @var y_data_ref
  # ID of a DataGenerator object.
  ## @var log_x
  # Boolean value stating whether the scale of the data generated by x_data_ref
  # is logarithmic.
  ## @var log_y
  # Boolean value stating whether the scale of the data generated by y_data_ref
  # is logarithmic.
  
  ## Overridden constructor.
  # @param self The object pointer.
  # @param curve A SED-ML curve element.
  # @param workflow A WorkFlow object.
  def __init__(self, curve, workflow):
    self.id = curve.getId()
    self.name = curve.getName()
    self.type = curve.getElementName()
    self.x_data_ref = workflow.get_data_generator_by_id(
      curve.getXDataReference())
    self.y_data_ref = workflow.get_data_generator_by_id(
      curve.getYDataReference())
    self.log_x = curve.getLogX()
    self.log_y = curve.getLogY()
  
  ## String representation of this. Displays it as a hierarchy.
  # @param self The object pointer.
  # @return A string representing this as a hierarchy.
  def __str__(self):
    tree = "      |-" + self.type + " id=" + self.id + " name=" + self.name
    tree += " xDataReference=" + self.x_data_ref.get_id()
    tree += " yDataReference=" + self.y_data_ref.get_id()
    tree += " logX=" + str(self.log_x)
    tree += " logY=" + str(self.log_y) + "\n"
    return tree
  
  ## Getter. Returns self.x_data_ref.
  # @param self The object pointer.
  # @return self.x_data_ref
  def get_x_data_ref(self):
    return self.x_data_ref
  
  ## Getter. Returns self.y_data_ref.
  # @param self The object pointer.
  # @return self.y_data_ref
  def get_y_data_ref(self):
    return self.y_data_ref
  
  ## Getter. Returns self.log_x.
  # @param self The object pointer.
  # @return self.x_data_ref
  def get_log_x(self):
    return self.log_x
  
  ## Getter. Returns self.log_y.
  # @param self The object pointer.
  # @return self.y_data_ref
  def get_log_y(self):
    return self.log_y
  
  ## Plot the data encoded in this on the input plot object.
  # @param self The object pointer.
  # @param plot The matplotlib object on which this should be added.
  def plot(self, plot):
    # Set the scale of the plot
    if self.log_x:
      plot.xscale('log')
    if self.log_y:
      plot.yscale('log')
    # Plot the values
    plot.plot(
      self.x_data_ref.get_values(),
      self.y_data_ref.get_values(),
      label=self.name)

## Data-derived class for 3-dimensional data set description.
class Surface(Data):
  ## @var x_data_ref
  # ID of a DataGenerator object.
  ## @var y_data_ref
  # ID of a DataGenerator object.
  ## @var z_data_ref
  # ID of a DataGenerator object.
  ## @var log_x
  # Boolean value stating whether the scale of the data generated by x_data_ref
  # is logarithmic.
  ## @var log_y
  # Boolean value stating whether the scale of the data generated by y_data_ref
  # is logarithmic.
  ## @var log_z
  # Boolean value stating whether the scale of the data generated by z_data_ref
  # is logarithmic.
  
  ## Overridden constructor.
  # @param self The object pointer.
  # @param surface A SED-ML surface element.
  # @param workflow A WorkFlow object.
  def __init__(self, surface, workflow):
    self.id = surface.getId()
    self.name = surface.getName()
    self.type = surface.getElementName()
    self.x_data_ref = workflow.get_data_generator_by_id(
      surface.getXDataReference())
    self.y_data_ref = workflow.get_data_generator_by_id(
      surface.getYDataReference())
    self.z_data_ref = workflow.get_data_generator_by_id(
      surface.getZDataReference())
    self.log_x = surface.getLogX()
    self.log_y = surface.getLogY()
    self.log_z = surface.getLogZ()
  
  ## String representation of this. Displays it as a hierarchy.
  # @param self The object pointer.
  # @return A string representing this as a hierarchy.
  def __str__(self):
    tree = "      |-" + self.type + " id=" + self.id + " name=" + self.name
    tree += " xDataReference=" + self.x_data_ref.get_id()
    tree += " yDataReference=" + self.y_data_ref.get_id()
    tree += " zDataReference=" + self.z_data_ref.get_id()
    tree += " logX=" + str(self.log_x)
    tree += " logY=" + str(self.log_y)
    tree += " logZ=" + str(self.log_z) + "\n"
    return tree
  
  ## Getter. Returns self.x_data_ref.
  # @param self The object pointer.
  # @return self.x_data_ref
  def get_x_data_ref(self):
    return self.x_data_ref
  
  ## Getter. Returns self.y_data_ref.
  # @param self The object pointer.
  # @return self.y_data_ref
  def get_y_data_ref(self):
    return self.y_data_ref
  
  ## Getter. Returns self.z_data_ref.
  # @param self The object pointer.
  # @return self.z_data_ref
  def get_z_data_ref(self):
    return self.z_data_ref
  
  ## Getter. Returns self.log_x.
  # @param self The object pointer.
  # @return self.x_data_ref
  def get_log_x(self):
    return self.log_x
  
  ## Getter. Returns self.log_y.
  # @param self The object pointer.
  # @return self.y_data_ref
  def get_log_y(self):
    return self.log_y
  
  ## Getter. Returns self.log_z.
  # @param self The object pointer.
  # @return self.z_data_ref
  def get_log_z(self):
    return self.log_z
  
  ## Plot the data encoded in this on the input plot object.
  # @param self The object pointer.
  # @param plot The matplotlib object on which this should be added.
  def plot(self, plot):
    # Set the scale of the plot
    if self.log_x:
      plot.xscale('log')
    if self.log_y:
      plot.yscale('log')
    if self.log_y:
      plot.zscale('log')
    # Plot the values
    plot.scatter(
      self.x_data_ref.get_values(),
      self.y_data_ref.get_values(),
      zs=self.z_data_ref.get_values()
      )