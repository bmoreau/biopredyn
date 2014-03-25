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
 * Implementation of SBML Level&nbsp;3's %ListOfLocalParameters construct.
 * 
 * The various ListOf___ classes in SBML are merely containers used for
 * organizing the main components of an SBML model.  All are derived from
 * the abstract class SBase, and inherit the various attributes and
 * subelements of SBase, such as 'metaid' as and 'annotation'.  The
 * ListOf___ classes do not add any attributes of their own.
 *
 * ListOfLocalParameters is a subsidiary object class used only within
 * KineticLaw in SBML Level&nbsp;3.  It is not defined in SBML Levels
 * 1&ndash;2.  In Level&nbsp;3, a KineticLaw object can have a single
 * object of class ListOfLocalParameters containing a set of local
 * parameters used in that kinetic law definition.
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

public class ListOfLocalParameters : ListOfParameters {
	private HandleRef swigCPtr;
	
	internal ListOfLocalParameters(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.ListOfLocalParameters_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.ListOfLocalParametersUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(ListOfLocalParameters obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (ListOfLocalParameters obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~ListOfLocalParameters() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_ListOfLocalParameters(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/**
   * Creates a new ListOfLocalParameters object.
   *
   * The object is constructed such that it is valid for the given SBML
   * Level and Version combination.
   *
   * @param level the SBML Level
   * 
   * @param version the Version within the SBML Level
   */ public
 ListOfLocalParameters(long level, long version) : this(libsbmlPINVOKE.new_ListOfLocalParameters__SWIG_0(level, version), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new ListOfLocalParameters object.
   *
   * The object is constructed such that it is valid for the SBML Level and
   * Version combination determined by the SBMLNamespaces object in @p
   * sbmlns.
   *
   * @param sbmlns an SBMLNamespaces object that is used to determine the
   * characteristics of the ListOfLocalParameters object to be created.
   */ public
 ListOfLocalParameters(SBMLNamespaces sbmlns) : this(libsbmlPINVOKE.new_ListOfLocalParameters__SWIG_1(SBMLNamespaces.getCPtr(sbmlns)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this ListOfLocalParameters object.
   *
   * @return a (deep) copy of this ListOfLocalParameters.
   */ public new
 ListOfLocalParameters clone() {
    IntPtr cPtr = libsbmlPINVOKE.ListOfLocalParameters_clone(swigCPtr);
    ListOfLocalParameters ret = (cPtr == IntPtr.Zero) ? null : new ListOfLocalParameters(cPtr, true);
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
    int ret = libsbmlPINVOKE.ListOfLocalParameters_getTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the libSBML type code for the objects contained in this ListOf
   * (i.e., LocalParameter objects, if the list is non-empty).
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
    int ret = libsbmlPINVOKE.ListOfLocalParameters_getItemTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the XML element name of this object.
   *
   * For ListOfLocalParameters, the XML element name is @c 'listOfLocalParameters'.
   * 
   * @return the name of this element, i.e., @c 'listOfLocalParameters'.
   */ public new
 string getElementName() {
    string ret = libsbmlPINVOKE.ListOfLocalParameters_getElementName(swigCPtr);
    return ret;
  }

  
/**
   * Returns the LocalParameter object located at position @p n within this
   * ListOfLocalParameters instance.
   *
   * @param n the index number of the LocalParameter to get.
   * 
   * @return the nth LocalParameter in this ListOfLocalParameters.  If the
   * index @p n is out of bounds for the length of the list, then @c null
   * is returned.
   *
   * @see size()
   * @see get(string sid)
   */ public new
 Parameter get(long n) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfLocalParameters_get__SWIG_0(swigCPtr, n);
    LocalParameter ret = (cPtr == IntPtr.Zero) ? null : new LocalParameter(cPtr, false);
    return ret;
  }

  
/**
   * Returns the first LocalParameter object matching the given identifier.
   *
   * @param sid a string, the identifier of the LocalParameter to get.
   * 
   * @return the LocalParameter object found.  The caller owns the returned
   * object and is responsible for deleting it.  If none of the items have
   * an identifier matching @p sid, then @c null is returned.
   *
   * @see get(long n)
   * @see size()
   */ public new
 Parameter get(string sid) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfLocalParameters_get__SWIG_2(swigCPtr, sid);
    LocalParameter ret = (cPtr == IntPtr.Zero) ? null : new LocalParameter(cPtr, false);
    return ret;
  }

  
/**
   * Returns the first child element found that has the given @p id in the model-wide SId namespace, or @c null if no such object is found.  Note that LocalParameters, while they use the SId namespace, are not in the model-wide SId namespace, so no LocalParameter object will be returned from this function (and is the reason we override the base ListOf::getElementBySId function here).
   *
   * @param id string representing the id of objects to find
   *
   * @return pointer to the first element found with the given @p id.
   */ public
 SBase getElementBySId(string id) {
	SBase ret = (SBase) libsbml.DowncastSBase(libsbmlPINVOKE.ListOfLocalParameters_getElementBySId(swigCPtr, id), false);
	return ret;
}

  
/**
   * Removes the nth item from this ListOfLocalParameters, and returns a
   * pointer to it.
   *
   * @param n the index of the item to remove.  
   *
   * @return the item removed.  The caller owns the returned object and is
   * responsible for deleting it.  If the index number @p n is out of
   * bounds for the length of the list, then @c null is returned.
   *
   * @see size()
   * @see remove(string sid)
   */ public new
 Parameter remove(long n) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfLocalParameters_remove__SWIG_0(swigCPtr, n);
    LocalParameter ret = (cPtr == IntPtr.Zero) ? null : new LocalParameter(cPtr, true);
    return ret;
  }

  
/**
   * Removes the first LocalParameter object in this ListOfLocalParameters
   * matching the given identifier, and returns a pointer to it.
   *
   * @param sid the identifier of the item to remove.
   *
   * @return the item removed.  The caller owns the returned object and is
   * responsible for deleting it.  If none of the items have an identifier
   * matching @p sid, then @c null is returned.
   */ public new
 Parameter remove(string sid) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfLocalParameters_remove__SWIG_1(swigCPtr, sid);
    LocalParameter ret = (cPtr == IntPtr.Zero) ? null : new LocalParameter(cPtr, true);
    return ret;
  }

}

}
