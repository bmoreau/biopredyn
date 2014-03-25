/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.6
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace libsbml {

 using System;
 using System.Runtime.InteropServices;

/** 
 * @ingroup Core
 * SBML converter for replacing function definitions.
 * 
 * @htmlinclude libsbml-facility-only-warning.html
 *
 * This is an SBML converter for manipulating user-defined functions in an
 * SBML file.  When invoked on the current model, it performs the following
 * operation:
 * <ol>
 * <li>Read the list of user-defined functions in the model (i.e., the
 * list of FunctionDefinition objects);
 * <li>Look for invocations of the function in mathematical expressions
 * throughout the model; and
 * <li>For each invocation found, replaces the invocation with a
 * in-line copy of the function's body, similar to how macro expansions
 * might be performed in scripting and programming languages.
 * </ol>
 *
 * For example, suppose the model contains a function definition
 * representing the function <i>f(x, y) = x * y</i>.  Further
 * suppose this functions invoked somewhere else in the model, in
 * a mathematical formula, as <i>f(s, p)</i>.  The outcome of running
 * SBMLFunctionDefinitionConverter on the model will be to replace
 * the call to <i>f</i> with the expression <i>s * p</i>.
 *
 * @see SBMLInitialAssignmentConverter
 * @see SBMLLevelVersionConverter
 * @see SBMLRuleConverter
 * @see SBMLStripPackageConverter
 * @see SBMLUnitsConverter
 */

public class SBMLFunctionDefinitionConverter : SBMLConverter {
	private HandleRef swigCPtr;
	
	internal SBMLFunctionDefinitionConverter(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.SBMLFunctionDefinitionConverter_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.SBMLFunctionDefinitionConverterUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(SBMLFunctionDefinitionConverter obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (SBMLFunctionDefinitionConverter obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~SBMLFunctionDefinitionConverter() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_SBMLFunctionDefinitionConverter(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static void init() {
    libsbmlPINVOKE.SBMLFunctionDefinitionConverter_init();
  }

  
/**
   * Creates a new SBMLFunctionDefinitionConverter object.
   */ public
 SBMLFunctionDefinitionConverter() : this(libsbmlPINVOKE.new_SBMLFunctionDefinitionConverter__SWIG_0(), true) {
  }

  
/**
   * Copy constructor; creates a copy of an SBMLFunctionDefinitionConverter
   * object.
   *
   * @param obj the SBMLFunctionDefinitionConverter object to copy.
   */ public
 SBMLFunctionDefinitionConverter(SBMLFunctionDefinitionConverter obj) : this(libsbmlPINVOKE.new_SBMLFunctionDefinitionConverter__SWIG_1(SBMLFunctionDefinitionConverter.getCPtr(obj)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this SBMLFunctionDefinitionConverter
   * object.
   * 
   * @return a (deep) copy of this converter.
   */ public
 SBMLConverter clone() {
    IntPtr cPtr = libsbmlPINVOKE.SBMLFunctionDefinitionConverter_clone(swigCPtr);
    SBMLConverter ret = (cPtr == IntPtr.Zero) ? null : new SBMLConverter(cPtr, true);
    return ret;
  }

  
/**
   * Returns @c true if this converter object's properties match the given
   * properties.
   *
   * A typical use of this method involves creating a ConversionProperties
   * object, setting the options desired, and then calling this method on
   * an SBMLFunctionDefinitionConverter object to find out if the object's
   * property values match the given ones.  This method is also used by
   * SBMLConverterRegistry::getConverterFor(@if java ConversionProperties props@endif)
   * to search across all registered converters for one matching particular
   * properties.
   * 
   * @param props the properties to match.
   * 
   * @return @c true if this converter's properties match, @c false
   * otherwise.
   */ public
 bool matchesProperties(ConversionProperties props) {
    bool ret = libsbmlPINVOKE.SBMLFunctionDefinitionConverter_matchesProperties(swigCPtr, ConversionProperties.getCPtr(props));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Replaces invocations of each user-defined function with an in-line
   * copy, similar to macro expansion.
   *
   * @return  integer value indicating the success/failure of the operation.
   * @if clike The value is drawn from the enumeration
   * #OperationReturnValues_t. @endif@~ The possible values are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_OBJECT LIBSBML_INVALID_OBJECT @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_CONV_INVALID_SRC_DOCUMENT LIBSBML_CONV_INVALID_SRC_DOCUMENT @endlink
   */ public
 int convert() {
    int ret = libsbmlPINVOKE.SBMLFunctionDefinitionConverter_convert(swigCPtr);
    return ret;
  }

  
/**
   * Returns the default properties of this converter.
   * 
   * A given converter exposes one or more properties that can be adjusted
   * in order to influence the behavior of the converter.  This method
   * returns the @em default property settings for this converter.  It is
   * meant to be called in order to discover all the settings for the
   * converter object.
   *
   * @return the ConversionProperties object describing the default properties
   * for this converter.
   */ public
 ConversionProperties getDefaultProperties() {
    ConversionProperties ret = new ConversionProperties(libsbmlPINVOKE.SBMLFunctionDefinitionConverter_getDefaultProperties(swigCPtr), true);
    return ret;
  }

}

}
