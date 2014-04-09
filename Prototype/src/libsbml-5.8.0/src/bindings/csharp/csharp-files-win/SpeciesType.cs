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
 * Implementation of SBML Level&nbsp;2's %SpeciesType construct.
 *
 * The term @em species @em type refers to reacting entities independent of
 * location.  These include simple ions (e.g., protons, calcium), simple
 * molecules (e.g., glucose, ATP), large molecules (e.g., RNA,
 * polysaccharides, and proteins), and others.
 * 
 * SBML Level&nbsp;2 Versions&nbsp;2&ndash;4 provide an explicit
 * SpeciesType class of object to enable Species objects of the same type
 * to be related together.  SpeciesType is a conceptual construct; the
 * existence of SpeciesType objects in a model has no effect on the model's
 * numerical interpretation.  Except for the requirement for uniqueness of
 * species/species type combinations located in compartments, simulators
 * and other numerical analysis software may ignore SpeciesType definitions
 * and references to them in a model.
 * 
 * There is no mechanism in SBML Level 2 for representing hierarchies of
 * species types.  One SpeciesType object cannot be the subtype of another
 * SpeciesType object; SBML provides no means of defining such
 * relationships.
 * 
 * As with other major structures in SBML, SpeciesType has a mandatory
 * attribute, 'id', used to give the species type an identifier.  The
 * identifier must be a text string conforming to the identifer syntax
 * permitted in SBML.  SpeciesType also has an optional 'name' attribute,
 * of type @c string.  The 'id' and 'name' must be used according to the
 * guidelines described in the SBML specification (e.g., Section 3.3 in
 * the Level&nbsp;2 Version&nbsp;4 specification).
 *
 * SpeciesType was introduced in SBML Level 2 Version 2.  It is not
 * available in SBML Level&nbsp;1 nor in Level&nbsp;3.
 *
 * @see Species
 * @see ListOfSpeciesTypes
 * @see CompartmentType
 * @see ListOfCompartmentTypes
 * 
 * <!---------------------------------------------------------------------- -->
 *
 */

public class SpeciesType : SBase {
	private HandleRef swigCPtr;
	
	internal SpeciesType(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.SpeciesType_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.SpeciesTypeUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(SpeciesType obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (SpeciesType obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~SpeciesType() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_SpeciesType(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/**
   * Creates a new SpeciesType using the given SBML @p level and @p version
   * values.
   *
   * @param level a long integer, the SBML Level to assign to this SpeciesType
   *
   * @param version a long integer, the SBML Version to assign to this
   * SpeciesType
   *
   * @throws @if python ValueError @else SBMLConstructorException @endif@~
   * Thrown if the given @p level and @p version combination, or this kind
   * of SBML object, are either invalid or mismatched with respect to the
   * parent SBMLDocument object.
   * 
   * @note Upon the addition of a SpeciesType object to an SBMLDocument
   * (e.g., using Model::addSpeciesType(@if java SpeciesType st@endif)),
   * the SBML Level, SBML Version and XML namespace of the document @em
   * override the values used when creating the SpeciesType object via this
   * constructor.  This is necessary to ensure that an SBML document is a
   * consistent structure.  Nevertheless, the ability to supply the values
   * at the time of creation of a SpeciesType is an important aid to
   * producing valid SBML.  Knowledge of the intented SBML Level and
   * Version determine whether it is valid to assign a particular value to
   * an attribute, or whether it is valid to add an object to an existing
   * SBMLDocument.
   */ public
 SpeciesType(long level, long version) : this(libsbmlPINVOKE.new_SpeciesType__SWIG_0(level, version), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new SpeciesType using the given SBMLNamespaces object
   * @p sbmlns.
   *
   * The SBMLNamespaces object encapsulates SBML Level/Version/namespaces
   * information.  It is used to communicate the SBML Level, Version, and
   * (in Level&nbsp;3) packages used in addition to SBML Level&nbsp;3 Core.
   * A common approach to using this class constructor is to create an
   * SBMLNamespaces object somewhere in a program, once, then pass it to
   * object constructors such as this one when needed.
   *
   * It is worth emphasizing that although this constructor does not take
   * an identifier argument, in SBML Level&nbsp;2 and beyond, the 'id'
   * (identifier) attribute of a SpeciesType object is required to have a value.
   * Thus, callers are cautioned to assign a value after calling this
   * constructor.  Setting the identifier can be accomplished using the
   * method SBase::setId(@if java String id@endif).
   *
   * @param sbmlns an SBMLNamespaces object.
   *
   * @throws @if python ValueError @else SBMLConstructorException @endif@~
   * Thrown if the given @p level and @p version combination, or this kind
   * of SBML object, are either invalid or mismatched with respect to the
   * parent SBMLDocument object.
   *
   * @note Upon the addition of a SpeciesType object to an SBMLDocument
   * (e.g., using Model::addSpeciesType(@if java SpeciesType st@endif)),
   * the SBML XML namespace of the document @em overrides the value used
   * when creating the SpeciesType object via this constructor.  This is
   * necessary to ensure that an SBML document is a consistent structure.
   * Nevertheless, the ability to supply the values at the time of creation
   * of a SpeciesType is an important aid to producing valid SBML.
   * Knowledge of the intented SBML Level and Version determine whether it
   * is valid to assign a particular value to an attribute, or whether it
   * is valid to add an object to an existing SBMLDocument.
   */ public
 SpeciesType(SBMLNamespaces sbmlns) : this(libsbmlPINVOKE.new_SpeciesType__SWIG_1(SBMLNamespaces.getCPtr(sbmlns)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Copy constructor; creates a copy of this SpeciesType.
   *
   * @param orig the object to copy.
   * 
   * @throws @if python ValueError @else SBMLConstructorException @endif@~
   * Thrown if the argument @p orig is @c null.
   */ public
 SpeciesType(SpeciesType orig) : this(libsbmlPINVOKE.new_SpeciesType__SWIG_2(SpeciesType.getCPtr(orig)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this SpeciesType.
   * 
   * @return a (deep) copy of this SpeciesType.
   */ public new
 SpeciesType clone() {
    IntPtr cPtr = libsbmlPINVOKE.SpeciesType_clone(swigCPtr);
    SpeciesType ret = (cPtr == IntPtr.Zero) ? null : new SpeciesType(cPtr, true);
    return ret;
  }

  
/**
   * Returns the value of the 'id' attribute of this SpeciesType.
   * 
   * @return the id of this SpeciesType.
   */ public new
 string getId() {
    string ret = libsbmlPINVOKE.SpeciesType_getId(swigCPtr);
    return ret;
  }

  
/**
   * Returns the value of the 'name' attribute of this SpeciesType.
   * 
   * @return the name of this SpeciesType.
   */ public new
 string getName() {
    string ret = libsbmlPINVOKE.SpeciesType_getName(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * SpeciesType's 'id' attribute is set.
   *
   * @return @c true if the 'id' attribute of this SpeciesType is
   * set, @c false otherwise.
   */ public new
 bool isSetId() {
    bool ret = libsbmlPINVOKE.SpeciesType_isSetId(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * SpeciesType's 'name' attribute is set.
   *
   * @return @c true if the 'name' attribute of this SpeciesType is
   * set, @c false otherwise.
   */ public new
 bool isSetName() {
    bool ret = libsbmlPINVOKE.SpeciesType_isSetName(swigCPtr);
    return ret;
  }

  
/**
   * Sets the value of the 'id' attribute of this SpeciesType.
   *
   * The string @p sid is copied.  Note that SBML has strict requirements
   * for the syntax of identifiers.  @htmlinclude id-syntax.html
   *
   * @param sid the string to use as the identifier of this SpeciesType
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif@~ The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   */ public new
 int setId(string sid) {
    int ret = libsbmlPINVOKE.SpeciesType_setId(swigCPtr, sid);
    return ret;
  }

  
/**
   * Sets the value of the 'name' attribute of this SpeciesType.
   *
   * The string in @p name is copied.
   *
   * @param name the new name for the SpeciesType
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif@~ The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   */ public new
 int setName(string name) {
    int ret = libsbmlPINVOKE.SpeciesType_setName(swigCPtr, name);
    return ret;
  }

  
/**
   * Unsets the value of the 'name' attribute of this SpeciesType.
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif@~ The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   */ public new
 int unsetName() {
    int ret = libsbmlPINVOKE.SpeciesType_unsetName(swigCPtr);
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
   * @return the SBML type code for this object, or @link libsbmlcs.libsbml.SBML_UNKNOWN SBML_UNKNOWN@endlink (default).
   *
   * @see getElementName()
   */ public new
 int getTypeCode() {
    int ret = libsbmlPINVOKE.SpeciesType_getTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the XML element name of this object, which for
   * SpeciesType, is always @c 'compartmentType'.
   * 
   * @return the name of this element, i.e., @c 'compartmentType'.
   */ public new
 string getElementName() {
    string ret = libsbmlPINVOKE.SpeciesType_getElementName(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if
   * all the required attributes for this SpeciesType object
   * have been set.
   *
   * @note The required attributes for a SpeciesType object are:
   * @li 'id'
   *
   * @return a bool value indicating whether all the required
   * attributes for this object have been defined.
   */ public new
 bool hasRequiredAttributes() {
    bool ret = libsbmlPINVOKE.SpeciesType_hasRequiredAttributes(swigCPtr);
    return ret;
  }

}

}