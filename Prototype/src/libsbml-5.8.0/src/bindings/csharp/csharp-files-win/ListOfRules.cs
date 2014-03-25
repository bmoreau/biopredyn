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
 * Implementation of SBML's %ListOfRules construct.
 * 
 * The various ListOf___ classes in %SBML are merely containers used for
 * organizing the main components of an %SBML model.  All are derived from
 * the abstract class SBase, and inherit the various attributes and
 * subelements of SBase, such as 'metaid' as and 'annotation'.  The
 * ListOf___ classes do not add any attributes of their own.
 *
 * The relationship between the lists and the rest of an %SBML model is
 * illustrated by the following (for SBML Level&nbsp;3 and later versions
 * of SBML Level&nbsp;2 as well):
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

public class ListOfRules : ListOf {
	private HandleRef swigCPtr;
	
	internal ListOfRules(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.ListOfRules_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.ListOfRulesUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(ListOfRules obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (ListOfRules obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~ListOfRules() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_ListOfRules(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/**
   * Creates a new ListOfRules object.
   *
   * The object is constructed such that it is valid for the given SBML
   * Level and Version combination.
   *
   * @param level the SBML Level
   * 
   * @param version the Version within the SBML Level
   */ public
 ListOfRules(long level, long version) : this(libsbmlPINVOKE.new_ListOfRules__SWIG_0(level, version), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new ListOfRules object.
   *
   * The object is constructed such that it is valid for the SBML Level and
   * Version combination determined by the SBMLNamespaces object in @p
   * sbmlns.
   *
   * @param sbmlns an SBMLNamespaces object that is used to determine the
   * characteristics of the ListOfRules object to be created.
   */ public
 ListOfRules(SBMLNamespaces sbmlns) : this(libsbmlPINVOKE.new_ListOfRules__SWIG_1(SBMLNamespaces.getCPtr(sbmlns)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this ListOfRules instance.
   *
   * @return a (deep) copy of this ListOfRules.
   */ public new
 ListOfRules clone() {
    IntPtr cPtr = libsbmlPINVOKE.ListOfRules_clone(swigCPtr);
    ListOfRules ret = (cPtr == IntPtr.Zero) ? null : new ListOfRules(cPtr, true);
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
    int ret = libsbmlPINVOKE.ListOfRules_getTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the libSBML type code for the objects contained in this ListOf
   * (i.e., Rule objects, if the list is non-empty).
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
    int ret = libsbmlPINVOKE.ListOfRules_getItemTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the XML element name of this object.
   *
   * For ListOfRules, the XML element name is @c 'listOfRules'.
   * 
   * @return the name of this element, i.e., @c 'listOfRules'.
   */ public new
 string getElementName() {
    string ret = libsbmlPINVOKE.ListOfRules_getElementName(swigCPtr);
    return ret;
  }

  
/**
   * Get a Rule from the ListOfRules.
   *
   * @param n the index number of the Rule to get.
   * 
   * @return the nth Rule in this ListOfRules.
   *
   * @see size()
   */ public new
 Rule get(long n) {
        Rule ret = (Rule) libsbml.DowncastSBase(libsbmlPINVOKE.ListOfRules_get__SWIG_0(swigCPtr, n), false);
	return ret;
}

  
/**
   * Get a Rule from the ListOfRules
   * based on its identifier.
   *
   * @param sid a string representing the identifier 
   * of the Rule to get.
   * 
   * @return Rule in this ListOfRules
   * with the given @p id or @c null if no such
   * Rule exists.
   *
   * @see get(long n)
   * @see size()
   */ public new
 Rule get(string sid) {
        Rule ret = (Rule) libsbml.DowncastSBase(libsbmlPINVOKE.ListOfRules_get__SWIG_2(swigCPtr, sid), false);
	return ret;
}

  
/**
   * Removes the nth item from this ListOfRules items and returns a pointer to
   * it.
   *
   * The caller owns the returned item and is responsible for deleting it.
   *
   * @param n the index of the item to remove
   *
   * @see size()
   */ public new
 Rule remove(long n) {
        Rule ret = (Rule) libsbml.DowncastSBase(libsbmlPINVOKE.ListOfRules_remove__SWIG_0(swigCPtr, n), true);
	return ret;
}

  
/**
   * Returns the first child element found that has the given @p id in the model-wide SId namespace, or @c null if no such object is found.  Note that AssignmentRules and RateRules do not actually have IDs, but the libsbml interface pretends that they do:  no assignment rule or rate rule is returned by this function.
   *
   * @param id string representing the id of objects to find
   *
   * @return pointer to the first element found with the given @p id.
   */ public
 SBase getElementBySId(string id) {
	SBase ret = (SBase) libsbml.DowncastSBase(libsbmlPINVOKE.ListOfRules_getElementBySId(swigCPtr, id), false);
	return ret;
}

  
/**
   * Removes item in this ListOfRules items with the given identifier.
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
 Rule remove(string sid) {
        Rule ret = (Rule) libsbml.DowncastSBase(libsbmlPINVOKE.ListOfRules_remove__SWIG_1(swigCPtr, sid), true);
	return ret;
}

}

}
