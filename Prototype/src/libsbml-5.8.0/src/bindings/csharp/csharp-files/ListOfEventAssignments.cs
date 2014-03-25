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
 * Implementation of SBML's %ListOfEventAssignments construct.
 *
 * The various ListOf___ classes in %SBML are merely containers used for
 * organizing the main components of an %SBML model.  All are derived from
 * the abstract class SBase, and inherit the various attributes and
 * subelements of SBase, such as 'metaid' as and 'annotation'.  The
 * ListOf___ classes do not add any attributes of their own.
 *
 * ListOfEventAssignments is entirely contained within Event.
 */

public class ListOfEventAssignments : ListOf {
	private HandleRef swigCPtr;
	
	internal ListOfEventAssignments(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.ListOfEventAssignments_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.ListOfEventAssignmentsUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(ListOfEventAssignments obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (ListOfEventAssignments obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~ListOfEventAssignments() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_ListOfEventAssignments(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/**
   * Creates a new ListOfEventAssignments object.
   *
   * The object is constructed such that it is valid for the given SBML
   * Level and Version combination.
   *
   * @param level the SBML Level
   * 
   * @param version the Version within the SBML Level
   */ public
 ListOfEventAssignments(long level, long version) : this(libsbmlPINVOKE.new_ListOfEventAssignments__SWIG_0(level, version), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new ListOfEventAssignments object.
   *
   * The object is constructed such that it is valid for the SBML Level and
   * Version combination determined by the SBMLNamespaces object in @p
   * sbmlns.
   *
   * @param sbmlns an SBMLNamespaces object that is used to determine the
   * characteristics of the ListOfEventAssignments object to be created.
   */ public
 ListOfEventAssignments(SBMLNamespaces sbmlns) : this(libsbmlPINVOKE.new_ListOfEventAssignments__SWIG_1(SBMLNamespaces.getCPtr(sbmlns)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this ListOfEventAssignments.
   *
   * @return a (deep) copy of this ListOfEventAssignments.
   */ public new
 ListOfEventAssignments clone() {
    IntPtr cPtr = libsbmlPINVOKE.ListOfEventAssignments_clone(swigCPtr);
    ListOfEventAssignments ret = (cPtr == IntPtr.Zero) ? null : new ListOfEventAssignments(cPtr, true);
    return ret;
  }

  
/**
   * Returns the libSBML type code for this %SBML object.
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
   * @return the SBML type code for this object, or @link libsbmlcs.libsbml.SBML_UNKNOWN SBML_UNKNOWN@endlink (default).
   *
   * @see getElementName()
   */ public new
 int getTypeCode() {
    int ret = libsbmlPINVOKE.ListOfEventAssignments_getTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the libSBML type code for the objects contained in this ListOf
   * (i.e., EventAssignment objects, if the list is non-empty).
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
   * instance, or @link libsbmlcs.libsbml.SBML_UNKNOWN SBML_UNKNOWN@endlink (default).
   *
   * @see getElementName()
   */ public new
 int getItemTypeCode() {
    int ret = libsbmlPINVOKE.ListOfEventAssignments_getItemTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the XML element name of this object.
   *
   * For ListOfEventAssignments, the XML element name is @c
   * 'listOfEventAssignments'.
   * 
   * @return the name of this element, i.e., @c 'listOfEventAssignments'.
   */ public new
 string getElementName() {
    string ret = libsbmlPINVOKE.ListOfEventAssignments_getElementName(swigCPtr);
    return ret;
  }

  
/**
   * Get a EventAssignment from the ListOfEventAssignments.
   *
   * @param n the index number of the EventAssignment to get.
   * 
   * @return the nth EventAssignment in this ListOfEventAssignments.
   *
   * @see size()
   */ public new
 EventAssignment get(long n) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfEventAssignments_get__SWIG_0(swigCPtr, n);
    EventAssignment ret = (cPtr == IntPtr.Zero) ? null : new EventAssignment(cPtr, false);
    return ret;
  }

  
/**
   * Get a EventAssignment from the ListOfEventAssignments
   * based on its identifier.
   *
   * @param sid a string representing the identifier 
   * of the EventAssignment to get.
   * 
   * @return EventAssignment in this ListOfEventAssignments
   * with the given @p sid or @c null if no such
   * EventAssignment exists.
   *
   * @see get(long n)
   * @see size()
   */ public new
 EventAssignment get(string sid) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfEventAssignments_get__SWIG_2(swigCPtr, sid);
    EventAssignment ret = (cPtr == IntPtr.Zero) ? null : new EventAssignment(cPtr, false);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Removes the nth item from this ListOfEventAssignments items and returns a pointer to
   * it.
   *
   * The caller owns the returned item and is responsible for deleting it.
   *
   * @param n the index of the item to remove
   *
   * @see size()
   */ public new
 EventAssignment remove(long n) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfEventAssignments_remove__SWIG_0(swigCPtr, n);
    EventAssignment ret = (cPtr == IntPtr.Zero) ? null : new EventAssignment(cPtr, true);
    return ret;
  }

  
/**
   * Removes item in this ListOfEventAssignments items with the given identifier.
   *
   * The caller owns the returned item and is responsible for deleting it.
   * If none of the items in this list have the identifier @p sid, then @c
   * null is returned.
   *
   * @param sid the identifier of the item to remove
   *
   * @return the item removed.  As mentioned above, the caller owns the
   * returned item.
   */ public new
 EventAssignment remove(string sid) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfEventAssignments_remove__SWIG_1(swigCPtr, sid);
    EventAssignment ret = (cPtr == IntPtr.Zero) ? null : new EventAssignment(cPtr, true);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Returns the first child element found that has the given @p id in the model-wide SId namespace, or @c null if no such object is found.  Note that EventAssignments do not actually have IDs, but the libsbml interface pretends that they do:  no event assignment is returned by this function.
   *
   * @param id string representing the id of objects to find
   *
   * @return pointer to the first element found with the given @p id.
   */ public
 SBase getElementBySId(string id) {
	SBase ret = (SBase) libsbml.DowncastSBase(libsbmlPINVOKE.ListOfEventAssignments_getElementBySId(swigCPtr, id), false);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
	return ret;
}

}

}
