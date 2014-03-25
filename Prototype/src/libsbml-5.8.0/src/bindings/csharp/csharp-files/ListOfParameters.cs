/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.6
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace libsbmlcs {

 using System;
 using System.Runtime.InteropServices;

/** 
 * @ingroup Core
 * Implementation of SBML's %ListOfParameters construct.
 * 
 * The various ListOf___ classes in SBML are merely containers used for
 * organizing the main components of an SBML model.  All are derived from
 * the abstract class SBase, and inherit the various attributes and
 * subelements of SBase, such as 'metaid' as and 'annotation'.  The
 * ListOf___ classes do not add any attributes of their own.
 *
 * The relationship between the lists and the rest of an SBML model is
 * illustrated by the following (for SBML Level&nbsp;2 Version&nbsp;4):
 *
 * @image html listof-illustration.jpg 'ListOf___ elements in an SBML Model'
 * @image latex listof-illustration.jpg 'ListOf___ elements in an SBML Model'
 *
 * Readers may wonder about the motivations for using the ListOf___
 * containers.  A simpler approach in XML might be to place the components
 * all directly at the top level of the model definition.  The choice made
 * in SBML is to group them within XML elements named after
 * ListOf<em>Classname</em>, in part because it helps organize the
 * components.  More importantly, the fact that the container classes are
 * derived from SBase means that software tools can add information @em about
 * the lists themselves into each list container's 'annotation'.
 *
 * @see ListOfFunctionDefinitions
 * @see ListOfUnitDefinitions
 * @see ListOfCompartmentTypes
 * @see ListOfSpeciesTypes
 * @see ListOfCompartments
 * @see ListOfSpecies
 * @see ListOfParameters
 * @see ListOfInitialAssignments
 * @see ListOfRules
 * @see ListOfConstraints
 * @see ListOfReactions
 * @see ListOfEvents
 */

public class ListOfParameters : ListOf {
	private HandleRef swigCPtr;
	
	internal ListOfParameters(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.ListOfParameters_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.ListOfParametersUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(ListOfParameters obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (ListOfParameters obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~ListOfParameters() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_ListOfParameters(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/**
   * Creates a new ListOfParameters object.
   *
   * The object is constructed such that it is valid for the given SBML
   * Level and Version combination.
   *
   * @param level the SBML Level
   * 
   * @param version the Version within the SBML Level
   */ public
 ListOfParameters(long level, long version) : this(libsbmlPINVOKE.new_ListOfParameters__SWIG_0(level, version), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new ListOfParameters object.
   * 
   * The object is constructed such that it is valid for the SBML Level and
   * Version combination determined by the SBMLNamespaces object in @p
   * sbmlns.
   *
   * @param sbmlns an SBMLNamespaces object that is used to determine the
   * characteristics of the ListOfParameters object to be created.
   */ public
 ListOfParameters(SBMLNamespaces sbmlns) : this(libsbmlPINVOKE.new_ListOfParameters__SWIG_1(SBMLNamespaces.getCPtr(sbmlns)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this ListOfParameters instance.
   *
   * @return a (deep) copy of this ListOfParameters.
   */ public new
 ListOfParameters clone() {
    IntPtr cPtr = libsbmlPINVOKE.ListOfParameters_clone(swigCPtr);
    ListOfParameters ret = (cPtr == IntPtr.Zero) ? null : new ListOfParameters(cPtr, true);
    return ret;
  }

  
/**
   * Returns the libSBML type code for this SBML object.
   *
   * @if clike LibSBML attaches an identifying code to every kind of SBML
   * object.  These are known as <em>SBML type codes</em>.  The set of
   * possible type codes is defined in the enumeration #SBMLTypeCode_t.
   * The names of the type codes all begin with the characters @c
   * SBML_. @endif@if java LibSBML attaches an identifying code to every
   * kind of SBML object.  These are known as <em>SBML type codes</em>.  In
   * other languages, the set of type codes is stored in an enumeration; in
   * the Java language interface for libSBML, the type codes are defined as
   * static integer constants in the interface class {@link
   * libsbmlConstants}.  The names of the type codes all begin with the
   * characters @c SBML_. @endif@if python LibSBML attaches an identifying
   * code to every kind of SBML object.  These are known as <em>SBML type
   * codes</em>.  In the Python language interface for libSBML, the type
   * codes are defined as static integer constants in the interface class
   * @link libsbml@endlink.  The names of the type codes all begin with the
   * characters @c SBML_. @endif@if csharp LibSBML attaches an identifying
   * code to every kind of SBML object.  These are known as <em>SBML type
   * codes</em>.  In the C# language interface for libSBML, the type codes
   * are defined as static integer constants in the interface class @link
   * libsbmlcs.libsbml@endlink.  The names of the type codes all begin with
   * the characters @c SBML_. @endif@~
   *
   * @return the SBML type code for this object, or @link
   * libsbmlcs.libsbml.SBML_UNKNOWN SBML_UNKNOWN@endlink (default).
   *
   * @see getElementName()
   */ public new
 int getTypeCode() {
    int ret = libsbmlPINVOKE.ListOfParameters_getTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the libSBML type code for the objects contained in this ListOf
   * (i.e., Parameter objects, if the list is non-empty).
   * 
   * @if clike LibSBML attaches an identifying code to every kind of SBML
   * object.  These are known as <em>SBML type codes</em>.  The set of
   * possible type codes is defined in the enumeration #SBMLTypeCode_t.
   * The names of the type codes all begin with the characters @c
   * SBML_. @endif@if java LibSBML attaches an identifying code to every
   * kind of SBML object.  These are known as <em>SBML type codes</em>.  In
   * other languages, the set of type codes is stored in an enumeration; in
   * the Java language interface for libSBML, the type codes are defined as
   * static integer constants in the interface class {@link
   * libsbmlConstants}.  The names of the type codes all begin with the
   * characters @c SBML_. @endif@if python LibSBML attaches an identifying
   * code to every kind of SBML object.  These are known as <em>SBML type
   * codes</em>.  In the Python language interface for libSBML, the type
   * codes are defined as static integer constants in the interface class
   * @link libsbml@endlink.  The names of the type codes all begin with the
   * characters @c SBML_. @endif@if csharp LibSBML attaches an identifying
   * code to every kind of SBML object.  These are known as <em>SBML type
   * codes</em>.  In the C# language interface for libSBML, the type codes
   * are defined as static integer constants in the interface class @link
   * libsbmlcs.libsbml@endlink.  The names of the type codes all begin with
   * the characters @c SBML_. @endif@~
   * 
   * @return the SBML type code for the objects contained in this ListOf
   * instance, or @link libsbmlcs.libsbml.SBML_UNKNOWN SBML_UNKNOWN@endlink
   * (default).
   *
   * @see getElementName()
   */ public new
 int getItemTypeCode() {
    int ret = libsbmlPINVOKE.ListOfParameters_getItemTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the XML element name of this object.
   *
   * For ListOfParameters, the XML element name is @c 'listOfParameters'.
   * 
   * @return the name of this element, i.e., @c 'listOfParameters'.
   */ public new
 string getElementName() {
    string ret = libsbmlPINVOKE.ListOfParameters_getElementName(swigCPtr);
    return ret;
  }

  
/**
   * Returns the Parameter object located at position @p n within this
   * ListOfParameters instance.
   *
   * @param n the index number of the Parameter to get.
   * 
   * @return the nth Parameter in this ListOfParameters.  If the index @p n
   * is out of bounds for the length of the list, then @c null is returned.
   *
   * @see size()
   * @see get(string sid)
   */ public new
 Parameter get(long n) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfParameters_get__SWIG_0(swigCPtr, n);
    Parameter ret = (cPtr == IntPtr.Zero) ? null : new Parameter(cPtr, false);
    return ret;
  }

  
/**
   * Returns the first Parameter object matching the given identifier.
   *
   * @param sid a string, the identifier of the Parameter to get.
   * 
   * @return the Parameter object found.  The caller owns the returned
   * object and is responsible for deleting it.  If none of the items have
   * an identifier matching @p sid, then @c null is returned.
   *
   * @see get(long n)
   * @see size()
   */ public new
 Parameter get(string sid) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfParameters_get__SWIG_2(swigCPtr, sid);
    Parameter ret = (cPtr == IntPtr.Zero) ? null : new Parameter(cPtr, false);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Removes the nth item from this ListOfParameters, and returns a pointer
   * to it.
   *
   * @param n the index of the item to remove
   *
   * @return the item removed.  The caller owns the returned object and is
   * responsible for deleting it.  If the index number @p n is out of
   * bounds for the length of the list, then @c null is returned.
   *
   * @see size()
   */ public new
 Parameter remove(long n) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfParameters_remove__SWIG_0(swigCPtr, n);
    Parameter ret = (cPtr == IntPtr.Zero) ? null : new Parameter(cPtr, true);
    return ret;
  }

  
/**
   * Removes the first Parameter object in this ListOfParameters
   * matching the given identifier, and returns a pointer to it.
   *
   * @param sid the identifier of the item to remove.
   *
   * @return the item removed.  The caller owns the returned object and is
   * responsible for deleting it.  If none of the items have an identifier
   * matching @p sid, then @c null is returned.
   */ public new
 Parameter remove(string sid) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfParameters_remove__SWIG_1(swigCPtr, sid);
    Parameter ret = (cPtr == IntPtr.Zero) ? null : new Parameter(cPtr, true);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
