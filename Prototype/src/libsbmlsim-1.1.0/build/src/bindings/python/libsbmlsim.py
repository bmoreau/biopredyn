# This file was automatically generated by SWIG (http://www.swig.org).
# Version 2.0.10
#
# Do not make changes to this file unless you know what you are doing--modify
# the SWIG interface file instead.



from sys import version_info
if version_info >= (2,6,0):
    def swig_import_helper():
        from os.path import dirname
        import imp
        fp = None
        try:
            fp, pathname, description = imp.find_module('_libsbmlsim', [dirname(__file__)])
        except ImportError:
            import _libsbmlsim
            return _libsbmlsim
        if fp is not None:
            try:
                _mod = imp.load_module('_libsbmlsim', fp, pathname, description)
            finally:
                fp.close()
            return _mod
    _libsbmlsim = swig_import_helper()
    del swig_import_helper
else:
    import _libsbmlsim
del version_info
try:
    _swig_property = property
except NameError:
    pass # Python < 2.2 doesn't have 'property'.
def _swig_setattr_nondynamic(self,class_type,name,value,static=1):
    if (name == "thisown"): return self.this.own(value)
    if (name == "this"):
        if type(value).__name__ == 'SwigPyObject':
            self.__dict__[name] = value
            return
    method = class_type.__swig_setmethods__.get(name,None)
    if method: return method(self,value)
    if (not static):
        self.__dict__[name] = value
    else:
        raise AttributeError("You cannot add attributes to %s" % self)

def _swig_setattr(self,class_type,name,value):
    return _swig_setattr_nondynamic(self,class_type,name,value,0)

def _swig_getattr(self,class_type,name):
    if (name == "thisown"): return self.this.own()
    method = class_type.__swig_getmethods__.get(name,None)
    if method: return method(self)
    raise AttributeError(name)

def _swig_repr(self):
    try: strthis = "proxy of " + self.this.__repr__()
    except: strthis = ""
    return "<%s.%s; %s >" % (self.__class__.__module__, self.__class__.__name__, strthis,)

try:
    _object = object
    _newclass = 1
except AttributeError:
    class _object : pass
    _newclass = 0


MTHD_EULER = _libsbmlsim.MTHD_EULER
MTHD_ADAMS_BASHFORTH_1 = _libsbmlsim.MTHD_ADAMS_BASHFORTH_1
MTHD_ADAMS_BASHFORTH_2 = _libsbmlsim.MTHD_ADAMS_BASHFORTH_2
MTHD_ADAMS_BASHFORTH_3 = _libsbmlsim.MTHD_ADAMS_BASHFORTH_3
MTHD_ADAMS_BASHFORTH_4 = _libsbmlsim.MTHD_ADAMS_BASHFORTH_4
MTHD_RUNGE_KUTTA = _libsbmlsim.MTHD_RUNGE_KUTTA
MTHD_RUNGE_KUTTA_FEHLBERG_5 = _libsbmlsim.MTHD_RUNGE_KUTTA_FEHLBERG_5
MTHD_CASH_KARP = _libsbmlsim.MTHD_CASH_KARP
MTHD_BACKWARD_EULER = _libsbmlsim.MTHD_BACKWARD_EULER
MTHD_CRANK_NICOLSON = _libsbmlsim.MTHD_CRANK_NICOLSON
MTHD_ADAMS_MOULTON_2 = _libsbmlsim.MTHD_ADAMS_MOULTON_2
MTHD_ADAMS_MOULTON_3 = _libsbmlsim.MTHD_ADAMS_MOULTON_3
MTHD_ADAMS_MOULTON_4 = _libsbmlsim.MTHD_ADAMS_MOULTON_4
MTHD_BACKWARD_DIFFERENCE_2 = _libsbmlsim.MTHD_BACKWARD_DIFFERENCE_2
MTHD_BACKWARD_DIFFERENCE_3 = _libsbmlsim.MTHD_BACKWARD_DIFFERENCE_3
MTHD_BACKWARD_DIFFERENCE_4 = _libsbmlsim.MTHD_BACKWARD_DIFFERENCE_4
MTHD_NAME_EULER = _libsbmlsim.MTHD_NAME_EULER
MTHD_NAME_ADAMS_BASHFORTH_1 = _libsbmlsim.MTHD_NAME_ADAMS_BASHFORTH_1
MTHD_NAME_ADAMS_BASHFORTH_2 = _libsbmlsim.MTHD_NAME_ADAMS_BASHFORTH_2
MTHD_NAME_ADAMS_BASHFORTH_3 = _libsbmlsim.MTHD_NAME_ADAMS_BASHFORTH_3
MTHD_NAME_ADAMS_BASHFORTH_4 = _libsbmlsim.MTHD_NAME_ADAMS_BASHFORTH_4
MTHD_NAME_RUNGE_KUTTA = _libsbmlsim.MTHD_NAME_RUNGE_KUTTA
MTHD_NAME_RUNGE_KUTTA_FEHLBERG_5 = _libsbmlsim.MTHD_NAME_RUNGE_KUTTA_FEHLBERG_5
MTHD_NAME_CASH_KARP = _libsbmlsim.MTHD_NAME_CASH_KARP
MTHD_NAME_BACKWARD_EULER = _libsbmlsim.MTHD_NAME_BACKWARD_EULER
MTHD_NAME_CRANK_NICOLSON = _libsbmlsim.MTHD_NAME_CRANK_NICOLSON
MTHD_NAME_ADAMS_MOULTON_2 = _libsbmlsim.MTHD_NAME_ADAMS_MOULTON_2
MTHD_NAME_ADAMS_MOULTON_3 = _libsbmlsim.MTHD_NAME_ADAMS_MOULTON_3
MTHD_NAME_ADAMS_MOULTON_4 = _libsbmlsim.MTHD_NAME_ADAMS_MOULTON_4
MTHD_NAME_BACKWARD_DIFFERENCE_2 = _libsbmlsim.MTHD_NAME_BACKWARD_DIFFERENCE_2
MTHD_NAME_BACKWARD_DIFFERENCE_3 = _libsbmlsim.MTHD_NAME_BACKWARD_DIFFERENCE_3
MTHD_NAME_BACKWARD_DIFFERENCE_4 = _libsbmlsim.MTHD_NAME_BACKWARD_DIFFERENCE_4
NoError = _libsbmlsim.NoError
Unknown = _libsbmlsim.Unknown
FileNotFound = _libsbmlsim.FileNotFound
InvalidSBML = _libsbmlsim.InvalidSBML
SBMLOperationFailed = _libsbmlsim.SBMLOperationFailed
InternalParserError = _libsbmlsim.InternalParserError
OutOfMemory = _libsbmlsim.OutOfMemory
SimulationFailed = _libsbmlsim.SimulationFailed
class myResult(_object):
    __swig_setmethods__ = {}
    __setattr__ = lambda self, name, value: _swig_setattr(self, myResult, name, value)
    __swig_getmethods__ = {}
    __getattr__ = lambda self, name: _swig_getattr(self, myResult, name)
    __repr__ = _swig_repr
    __swig_setmethods__["error_code"] = _libsbmlsim.myResult_error_code_set
    __swig_getmethods__["error_code"] = _libsbmlsim.myResult_error_code_get
    if _newclass:error_code = _swig_property(_libsbmlsim.myResult_error_code_get, _libsbmlsim.myResult_error_code_set)
    __swig_getmethods__["error_message"] = _libsbmlsim.myResult_error_message_get
    if _newclass:error_message = _swig_property(_libsbmlsim.myResult_error_message_get)
    __swig_setmethods__["num_of_rows"] = _libsbmlsim.myResult_num_of_rows_set
    __swig_getmethods__["num_of_rows"] = _libsbmlsim.myResult_num_of_rows_get
    if _newclass:num_of_rows = _swig_property(_libsbmlsim.myResult_num_of_rows_get, _libsbmlsim.myResult_num_of_rows_set)
    __swig_setmethods__["num_of_columns_sp"] = _libsbmlsim.myResult_num_of_columns_sp_set
    __swig_getmethods__["num_of_columns_sp"] = _libsbmlsim.myResult_num_of_columns_sp_get
    if _newclass:num_of_columns_sp = _swig_property(_libsbmlsim.myResult_num_of_columns_sp_get, _libsbmlsim.myResult_num_of_columns_sp_set)
    __swig_setmethods__["num_of_columns_param"] = _libsbmlsim.myResult_num_of_columns_param_set
    __swig_getmethods__["num_of_columns_param"] = _libsbmlsim.myResult_num_of_columns_param_get
    if _newclass:num_of_columns_param = _swig_property(_libsbmlsim.myResult_num_of_columns_param_get, _libsbmlsim.myResult_num_of_columns_param_set)
    __swig_setmethods__["num_of_columns_comp"] = _libsbmlsim.myResult_num_of_columns_comp_set
    __swig_getmethods__["num_of_columns_comp"] = _libsbmlsim.myResult_num_of_columns_comp_get
    if _newclass:num_of_columns_comp = _swig_property(_libsbmlsim.myResult_num_of_columns_comp_get, _libsbmlsim.myResult_num_of_columns_comp_set)
    __swig_getmethods__["column_name_time"] = _libsbmlsim.myResult_column_name_time_get
    if _newclass:column_name_time = _swig_property(_libsbmlsim.myResult_column_name_time_get)
    __swig_getmethods__["column_name_sp"] = _libsbmlsim.myResult_column_name_sp_get
    if _newclass:column_name_sp = _swig_property(_libsbmlsim.myResult_column_name_sp_get)
    __swig_getmethods__["column_name_param"] = _libsbmlsim.myResult_column_name_param_get
    if _newclass:column_name_param = _swig_property(_libsbmlsim.myResult_column_name_param_get)
    __swig_getmethods__["column_name_comp"] = _libsbmlsim.myResult_column_name_comp_get
    if _newclass:column_name_comp = _swig_property(_libsbmlsim.myResult_column_name_comp_get)
    __swig_setmethods__["values_time"] = _libsbmlsim.myResult_values_time_set
    __swig_getmethods__["values_time"] = _libsbmlsim.myResult_values_time_get
    if _newclass:values_time = _swig_property(_libsbmlsim.myResult_values_time_get, _libsbmlsim.myResult_values_time_set)
    __swig_setmethods__["values_sp"] = _libsbmlsim.myResult_values_sp_set
    __swig_getmethods__["values_sp"] = _libsbmlsim.myResult_values_sp_get
    if _newclass:values_sp = _swig_property(_libsbmlsim.myResult_values_sp_get, _libsbmlsim.myResult_values_sp_set)
    __swig_setmethods__["values_param"] = _libsbmlsim.myResult_values_param_set
    __swig_getmethods__["values_param"] = _libsbmlsim.myResult_values_param_get
    if _newclass:values_param = _swig_property(_libsbmlsim.myResult_values_param_get, _libsbmlsim.myResult_values_param_set)
    __swig_setmethods__["values_comp"] = _libsbmlsim.myResult_values_comp_set
    __swig_getmethods__["values_comp"] = _libsbmlsim.myResult_values_comp_get
    if _newclass:values_comp = _swig_property(_libsbmlsim.myResult_values_comp_get, _libsbmlsim.myResult_values_comp_set)
    __swig_setmethods__["values_time_fordelay"] = _libsbmlsim.myResult_values_time_fordelay_set
    __swig_getmethods__["values_time_fordelay"] = _libsbmlsim.myResult_values_time_fordelay_get
    if _newclass:values_time_fordelay = _swig_property(_libsbmlsim.myResult_values_time_fordelay_get, _libsbmlsim.myResult_values_time_fordelay_set)
    __swig_setmethods__["num_of_delay_rows"] = _libsbmlsim.myResult_num_of_delay_rows_set
    __swig_getmethods__["num_of_delay_rows"] = _libsbmlsim.myResult_num_of_delay_rows_get
    if _newclass:num_of_delay_rows = _swig_property(_libsbmlsim.myResult_num_of_delay_rows_get, _libsbmlsim.myResult_num_of_delay_rows_set)
    def __init__(self): 
        this = _libsbmlsim.new_myResult()
        try: self.this.append(this)
        except: self.this = this
    __swig_destroy__ = _libsbmlsim.delete_myResult
    __del__ = lambda self : None;
    def isError(self): return _libsbmlsim.myResult_isError(self)
    def getErrorCode(self): return _libsbmlsim.myResult_getErrorCode(self)
    def getErrorMessage(self): return _libsbmlsim.myResult_getErrorMessage(self)
    def getNumOfRows(self): return _libsbmlsim.myResult_getNumOfRows(self)
    def getNumOfSpecies(self): return _libsbmlsim.myResult_getNumOfSpecies(self)
    def getNumOfParameters(self): return _libsbmlsim.myResult_getNumOfParameters(self)
    def getNumOfCompartments(self): return _libsbmlsim.myResult_getNumOfCompartments(self)
    def getTimeName(self): return _libsbmlsim.myResult_getTimeName(self)
    def getSpeciesNameAtIndex(self, *args): return _libsbmlsim.myResult_getSpeciesNameAtIndex(self, *args)
    def getParameterNameAtIndex(self, *args): return _libsbmlsim.myResult_getParameterNameAtIndex(self, *args)
    def getCompartmentNameAtIndex(self, *args): return _libsbmlsim.myResult_getCompartmentNameAtIndex(self, *args)
    def getTimeValueAtIndex(self, *args): return _libsbmlsim.myResult_getTimeValueAtIndex(self, *args)
    def getSpeciesValueAtIndex(self, *args): return _libsbmlsim.myResult_getSpeciesValueAtIndex(self, *args)
    def getParameterValueAtIndex(self, *args): return _libsbmlsim.myResult_getParameterValueAtIndex(self, *args)
    def getCompartmentValueAtIndex(self, *args): return _libsbmlsim.myResult_getCompartmentValueAtIndex(self, *args)
myResult_swigregister = _libsbmlsim.myResult_swigregister
myResult_swigregister(myResult)


def simulateSBMLFromFile(*args):
  return _libsbmlsim.simulateSBMLFromFile(*args)
simulateSBMLFromFile = _libsbmlsim.simulateSBMLFromFile

def simulateSBMLFromString(*args):
  return _libsbmlsim.simulateSBMLFromString(*args)
simulateSBMLFromString = _libsbmlsim.simulateSBMLFromString

def print_result(*args):
  return _libsbmlsim.print_result(*args)
print_result = _libsbmlsim.print_result

def write_result(*args):
  return _libsbmlsim.write_result(*args)
write_result = _libsbmlsim.write_result

def write_csv(*args):
  return _libsbmlsim.write_csv(*args)
write_csv = _libsbmlsim.write_csv

def write_separate_result(*args):
  return _libsbmlsim.write_separate_result(*args)
write_separate_result = _libsbmlsim.write_separate_result
# This file is compatible with both classic and new-style classes.

