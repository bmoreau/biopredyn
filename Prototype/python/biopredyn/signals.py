#!/usr/bin/env python
# coding=utf-8

## @package biopredyn
## Copyright: [2012-2015] The CoSMo Company, All Rights Reserved
## License: BSD 3-Clause

from matplotlib import pyplot as plt
from matplotlib.collections import LineCollection
from mpl_toolkits.mplot3d import Axes3D
import numpy as np
from random import gauss

## Base class for data description.
class Data:
  ## @var id
  # A unique identifier.
  ## @var name
  # Name of this object.
  ## @var type
  # Type of output.
  ## @var workflow
  # Reference to the WorkFlow object this belongs to.
  
  ## Constructor; either 'data' or 'idf' ad 'typ' must be passed
  ## as keyword argument(s).
  # @param self The object pointer.
  # @param workflow A WorkFlow object.
  # @param data A virtual libsedml element; optional (default: None).
  # @param idf A unique identifier; optional (default: None).
  # @param name A name for 'self'; optional (default: None).
  # @param typ The type of data encoded by 'self'; can be either 'curve',
  # 'surface' or 'dataSet'. Optional (default: None).
  def __init__(self, workflow, data=None, idf=None, name=None, typ=None):
    if data is None and (idf is None or typ is None):
      raise RuntimeError("Either 'data' or 'idf' ad 'typ' must be passed " +
        "as keyword argument(s).")
    else:
      self.workflow = workflow
      if data is not None:
        self.id = data.getId()
        self.name = data.getName()
        self.type = data.getElementName()
      else:
        self.id = idf
        self.name = name
        self.type = typ
  
  ## Getter. Returns self.id.
  # @param self The object pointer.
  def get_id(self):
    return self.id
  
  ## Setter for self.id.
  # @param self The object pointer.
  # @param id New value for self.id.
  def set_id(self, id):
    self.id = id
  
  ## Getter. Returns self.name.
  # @param self The object pointer.
  def get_name(self):
    return self.name
  
  ## Setter for self.name.
  # @param self The object pointer.
  # @param name New value for self.name.
  def set_name(self, name):
    self.name = name
  
  ## Getter. Returns self.workflow.
  # @param self The object pointer.
  def get_workflow(self):
    return self.workflow
  
  ## Setter for self.workflow.
  # @param self The object pointer.
  # @param workflow A biopredyn.workflow.WorkFlow object.
  def set_workflow(self, workflow):
    self.workflow = workflow
  
  ## Getter. Returns self.type.
  # @param self The object pointer.
  # @return self.type
  def get_type(self):
    return self.type

## Data-derived class for N-dimensional data set description.
class DataSet(Data):
  ## @var data_id
  # ID of a DataGenerator object.
  ## @var label
  # A label for this.
  
  ## Overridden constructor; either 'data' or 'idf', 'lbl' and 'dg_ref' must be
  ## passed as keyword argument(s).
  # @param self The object pointer.
  # @param workflow A WorkFlow object.
  # @param data A libsedml.SedDataSet element; optional (default: None).
  # @param idf A unique identifier; optional (default: None).
  # @param name A name for 'self'; optional (default: None).
  # @param lbl An unambiguous label describing 'self'; optional (default:
  # None).
  # @param dg_ref Identifier of a biopredyn.datagenerator.DataGenerator object
  # in 'workflow'; optional (default: None).
  def __init__(self, workflow, data=None, idf=None, name=None, lbl=None,
    dg_ref=None):
    if data is None and (idf is None or lbl is None or dg_ref is None):
      raise RuntimeError("Either 'data' or 'idf', 'lbl' and 'dg_ref' must be " +
        "passed as keyword argument(s).")
    else:
      if data is not None:
        Data.__init__(self, workflow, data=data)
        self.label = data.getLabel()
        self.data_id = data.getDataReference()
      else:
        Data.__init__(self, workflow, idf=idf, name=name, typ="dataSet")
        self.label = lbl
        self.data_id = dg_ref
  
  ## String representation of this. Displays it as a hierarchy.
  # @param self The object pointer.
  # @return A string representing this as a hierarchy.
  def __str__(self):
    tree = "      |-" + self.type + " id=" + self.id + " label=" + self.label
    tree += " dataReference=" + self.data_id + "\n"
    return tree
  
  ## Getter. Returns self.label.
  # @param self The object pointer.
  # @return self.label
  def get_label(self):
    return self.label
  
  ## Setter for self.label.
  # @param self The object pointer.
  # @param label New value for self.label.
  def set_label(self, label):
    self.label = label
  
  ## Returns the number of experiments in the data generated by the associated
  ## biopredyn.datagenerator.DataGenerator object.
  # @param self The object pointer.
  # @return An integer.
  def get_num_experiments(self):
    return self.get_data_gen().get_num_experiments()

  ## Returns the number of time points in self.data_ref.
  # @param self The object pointer.
  # @return An integer..
  def get_number_of_points(self):
    return self.get_data_gen().get_number_of_points()
  
  ## Returns the DataGenerator object of self.workflow which ID is self.data_id.
  # @param self The object pointer.
  # @return A DataGenerator object.
  def get_data_gen(self):
    return self.workflow.get_data_generator_by_id(self.data_id)
  
  ## Getter. Returns self.data_id.
  # @param self The object pointer.
  # @return self.data_id
  def get_data_id(self):
    return self.data_id
  
  ## Setter for self.data_id.
  # @param self The object pointer.
  # @param data_id New value for self.data_id.
  def set_data_id(self, data_id):
    self.data_id = data_id
  
  ## Write the data encoded in the input Dimension object.
  # Each data value is written in the composite value corresponding to its
  # iteration and index. It is assumed that all the series have the same number
  # of time points.
  # @param self The object pointer.
  # @param dim A Dimension instance.
  # @param artificial Whether this report should be used to generate artificial
  # data by adding noise to the non-time datasets. Default: False.
  # @param noise_type The type of noise to be added to the datasets. Possible
  # values are 'homoscedastic' (standard deviation of the noise is constant)
  # and 'heteroscedastic' (standard deviation is proportional to the value of
  # each data point). Default: 'heteroscedastic'.
  # @param std_dev Standard deviation of the noise distribution (gaussian). If
  # noise_type is 'homoscedastic', std_dev is the exact value of the standard
  # deviation; if noise_type is 'heteroscedastic', std_dev is a percentage.
  # Default: 0.1 
  def write_as_numl(self, dim, artificial, noise_type, std_dev):
    data_gen = self.get_data_gen()
    values = data_gen.get_values()
    for v in range(data_gen.get_number_of_points()):
      comp = dim.get(v)
      if str.lower(self.label).__contains__('time'):
        comp.setIndexValue(str(values[0][v]))
      else:
        # series level
        series = comp.createCompositeValue()
        series.setIndexValue(self.label)
        # experiment level
        for e in range(len(values)):
          exp = series.createCompositeValue()
          exp.setIndexValue(str(e))
          value = exp.createAtomicValue()
          if not artificial:
            value.setValue(str(values[e][v]))
          elif noise_type == 'heteroscedastic':
            value.setValue(str(gauss(values[e][v], values[e][v] * std_dev)))
          elif noise_type == 'homoscedastic':
            value.setValue(str(gauss(values[e][v], std_dev)))
          else:
            raise ValueError("Invalid noise type: " + noise_type +
              "\nExpected noise types are 'homoscedastic' or " +
              "'heteroscedastic'.")

## Data-derived class for 2-dimensional data set description.
class Curve(Data):
  ## @var x_data_id
  # ID of a DataGenerator object.
  ## @var y_data_id
  # ID of a DataGenerator object.
  ## @var log_x
  # Boolean value stating whether the scale of the data generated by x_data_ref
  # is logarithmic.
  ## @var log_y
  # Boolean value stating whether the scale of the data generated by y_data_ref
  # is logarithmic.
  
  ## Overridden constructor; either 'curve' or 'idf', 'xid', 'yid', 'logx' and
  ## 'logy' must be passed as keyword argument(s).
  # @param self The object pointer.
  # @param workflow A WorkFlow object.
  # @param curve A libsedml.SedCurve element; optional (default: None).
  # @param idf A unique identifier; optional (default: None).
  # @param name A name for 'self'; optional (default: None).
  # @param xid Identifier of a biopredyn.datagenerator.DataGenerator object in
  # 'workflow'; optional (default: None).
  # @param yid Identifier of a biopredyn.datagenerator.DataGenerator object in
  # 'workflow'; optional (default: None).
  # @param logx Boolean stating whether the dimension encoded in x should be
  # plotted on a logarithmic scale; optional (default: None).
  # @param logy Boolean stating whether the dimension encoded in y should be
  # plotted on a logarithmic scale; optional (default: None).
  def __init__(self, workflow, curve=None, idf=None, name=None, xid=None,
    yid=None, logx=None, logy=None):
    if curve is None and (idf is None or xid is None or yid is None or logx is
      None or logy is None):
      raise RuntimeError("Either 'curve' or 'idf', 'xid', 'yid', 'logx' and " +
        "'logy' must be passed as keyword argument(s).")
    else:
      if curve is not None:
        Data.__init__(self, workflow, data=curve)
        self.x_data_id = curve.getXDataReference()
        self.y_data_id = curve.getYDataReference()
        self.log_x = curve.getLogX()
        self.log_y = curve.getLogY()
      else:
        Data.__init__(self, workflow, idf=idf, name=name, typ='curve')
        self.x_data_id = xid
        self.y_data_id = yid
        self.log_x = logx
        self.log_y = logy
  
  ## String representation of this. Displays it as a hierarchy.
  # @param self The object pointer.
  # @return A string representing this as a hierarchy.
  def __str__(self):
    tree = "      |-" + self.type + " id=" + self.id + " name=" + self.name
    tree += " xDataReference=" + self.x_data_id
    tree += " yDataReference=" + self.y_data_id
    tree += " logX=" + str(self.log_x)
    tree += " logY=" + str(self.log_y) + "\n"
    return tree
  
  ## Getter. Returns self.x_data_id.
  # @param self The object pointer.
  # @return self.x_data_id
  def get_x_data_id(self):
    return self.x_data_id
  
  ## Setter for self.x_data_id.
  # @param self The object pointer.
  # @param x_data_id New value for self.x_data_id.
  def set_x_data_id(self, x_data_id):
    self.x_data_id = x_data_id
  
  ## Returns the DataGenerator object of self.workflow which ID is
  ## self.x_data_id.
  # @param self The object pointer.
  # @return A DataGenerator object.
  def get_x_data_gen(self):
    return self.workflow.get_data_generator_by_id(self.x_data_id)
  
  ## Getter. Returns self.y_data_id.
  # @param self The object pointer.
  # @return self.y_data_id
  def get_y_data_id(self):
    return self.y_data_id
  
  ## Setter for self.y_data_id.
  # @param self The object pointer.
  # @param y_data_id New value for self.id.
  def set_id(self, y_data_id):
    self.y_data_id = y_data_id
  
  ## Returns the DataGenerator object of self.workflow which ID is
  ## self.y_data_id.
  # @param self The object pointer.
  # @return A DataGenerator object.
  def get_y_data_gen(self):
    return self.workflow.get_data_generator_by_id(self.y_data_id)
  
  ## Getter. Returns self.log_x.
  # @param self The object pointer.
  # @return self.x_data_ref
  def get_log_x(self):
    return self.log_x
  
  ## Setter for self.log_x.
  # @param self The object pointer.
  # @param log_x New value for self.log_x.
  def set_log_x(self, log_x):
    self.log_x = log_x
  
  ## Getter. Returns self.log_y.
  # @param self The object pointer.
  # @return self.y_data_ref
  def get_log_y(self):
    return self.log_y
  
  ## Setter for self.log_y.
  # @param self The object pointer.
  # @param log_y New value for self.log_y.
  def set_log_y(self, log_y):
    self.log_y = log_y
  
  ## Plot the data encoded in this on the input plot object.
  # @param self The object pointer.
  # @param plot The matplotlib object on which this should be added.
  # @param col A 3-tuple representing a RGB color.
  def plot(self, plot, col):
    # Set the scale of the plot
    if self.log_x:
      plot.xscale('log')
    if self.log_y:
      plot.yscale('log')
    # Process the values
    values = []
    for x in self.get_x_data_gen().get_values():
      for y in self.get_y_data_gen().get_values():
        values.append(zip(x,y))
    lines = LineCollection(values)
    lines.set_color(col)
    lines.set_label(self.get_name())
    # Plot the values
    plot.add_collection(lines)

## Data-derived class for 3-dimensional data set description.
class Surface(Data):
  ## @var x_data_id
  # ID of a DataGenerator object.
  ## @var y_data_id
  # ID of a DataGenerator object.
  ## @var z_data_id
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
  
  ## Overridden constructor; either 'surf' or 'idf', 'xid', 'yid', 'zid',
  ## 'logx', 'logy' and 'logz' must be passed as keyword argument(s).
  # @param self The object pointer.
  # @param workflow A WorkFlow object.
  # @param surf A libsedml.SedSurface element; optional (default: None).
  # @param idf A unique identifier; optional (default: None).
  # @param name A name for 'self'; optional (default: None).
  # @param xid Identifier of a biopredyn.datagenerator.DataGenerator object in
  # 'workflow'; optional (default: None).
  # @param yid Identifier of a biopredyn.datagenerator.DataGenerator object in
  # 'workflow'; optional (default: None).
  # @param zid Identifier of a biopredyn.datagenerator.DataGenerator object in
  # 'workflow'; optional (default: None).
  # @param logx Boolean stating whether the dimension encoded in x should be
  # plotted on a logarithmic scale; optional (default: None).
  # @param logy Boolean stating whether the dimension encoded in y should be
  # plotted on a logarithmic scale; optional (default: None).
  # @param logz Boolean stating whether the dimension encoded in z should be
  # plotted on a logarithmic scale; optional (default: None).
  def __init__(self, workflow, surf=None, idf=None, name=None, xid=None,
    yid=None, zid=None, logx=None, logy=None, logz=None):
    if surf is None and (idf is None or xid is None or yid is None or zid is
      None or logx is None or logy is None or logz is None):
      raise RuntimeError("Either 'surf' or 'idf', 'xid', 'yid', 'zid', " +
        "'logx', 'logy' and 'logz' must be passed as keyword argument(s).")
    else:
      if surf is not None:
        Data.__init__(self, workflow, data=surf)
        self.x_data_id = surf.getXDataReference()
        self.y_data_id = surf.getYDataReference()
        self.z_data_id = surf.getZDataReference()
        self.log_x = surf.getLogX()
        self.log_y = surf.getLogY()
        self.log_z = surf.getLogZ()
      else:
        Data.__init__(self, workflow, idf=idf, name=name, typ='surface')
        self.x_data_id = xid
        self.y_data_id = yid
        self.z_data_id = zid
        self.log_x = logx
        self.log_y = logy
        self.log_z = logz
  
  ## String representation of this. Displays it as a hierarchy.
  # @param self The object pointer.
  # @return A string representing this as a hierarchy.
  def __str__(self):
    tree = "      |-" + self.type + " id=" + self.id + " name=" + self.name
    tree += " xDataReference=" + self.x_data_id
    tree += " yDataReference=" + self.y_data_id
    tree += " zDataReference=" + self.z_data_id
    tree += " logX=" + str(self.log_x)
    tree += " logY=" + str(self.log_y)
    tree += " logZ=" + str(self.log_z) + "\n"
    return tree
  
  ## Returns the DataGenerator object of self.workflow which ID is
  ## self.x_data_id.
  # @param self The object pointer.
  # @return A DataGenerator object.
  def get_x_data_gen(self):
    return self.workflow.get_data_generator_by_id(self.x_data_id)
  
  ## Getter. Returns self.x_data_id.
  # @param self The object pointer.
  # @return self.x_data_id
  def get_x_data_id(self):
    return self.x_data_id
  
  ## Setter for self.x_data_id.
  # @param self The object pointer.
  # @param x_data_id New value for self.x_data_id.
  def set_x_data_id(self, x_data_id):
    self.x_data_id = x_data_id
  
  ## Returns the DataGenerator object of self.workflow which ID is
  ## self.y_data_id.
  # @param self The object pointer.
  # @return A DataGenerator object.
  def get_y_data_gen(self):
    return self.workflow.get_data_generator_by_id(self.y_data_id)
  
  ## Getter. Returns self.y_data_id.
  # @param self The object pointer.
  # @return self.y_data_id
  def get_y_data_id(self):
    return self.y_data_id
  
  ## Setter for self.y_data_id.
  # @param self The object pointer.
  # @param y_data_id New value for self.y_data_id.
  def set_y_data_id(self, y_data_id):
    self.y_data_id = y_data_id
  
  ## Returns the DataGenerator object of self.workflow which ID is
  ## self.z_data_id.
  # @param self The object pointer.
  # @return A DataGenerator object.
  def get_z_data_gen(self):
    return self.workflow.get_data_generator_by_id(self.z_data_id)
  
  ## Getter. Returns self.z_data_id.
  # @param self The object pointer.
  # @return self.z_data_id
  def get_z_data_id(self):
    return self.z_data_id
  
  ## Setter for self.z_data_id.
  # @param self The object pointer.
  # @param z_data_id New value for self.z_data_id.
  def set_z_data_id(self, z_data_id):
    self.z_data_id = z_data_id
  
  ## Getter. Returns self.log_x.
  # @param self The object pointer.
  # @return self.x_data_ref
  def get_log_x(self):
    return self.log_x
  
  ## Setter for self.log_x.
  # @param self The object pointer.
  # @param log_x New value for self.log_x.
  def set_id(self, log_x):
    self.log_x = log_x
  
  ## Getter. Returns self.log_y.
  # @param self The object pointer.
  # @return self.y_data_ref
  def get_log_y(self):
    return self.log_y
  
  ## Setter for self.log_y.
  # @param self The object pointer.
  # @param log_y New value for self.log_y.
  def set_log_y(self, log_y):
    self.log_y = log_y
  
  ## Getter. Returns self.log_z.
  # @param self The object pointer.
  # @return self.z_data_ref
  def get_log_z(self):
    return self.log_z
  
  ## Setter for self.log_z.
  # @param self The object pointer.
  # @param log_z New value for self.log_z.
  def set_log_z(self, log_z):
    self.log_z = log_z
  
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
    x = np.array(self.get_x_data_gen().get_values())
    y = np.array(self.get_y_data_gen().get_values())
    z = np.array(self.get_z_data_gen().get_values())
    plot.scatter(x, y, zs=z)
