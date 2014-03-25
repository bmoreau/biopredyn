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
 * Implementation of %SBML's %SimpleSpeciesReference construct.
 *
 * As mentioned in the description of Reaction, every species that enters
 * into a given reaction must appear in that reaction's lists of reactants,
 * products and/or modifiers.  In an SBML model, all species that may
 * participate in any reaction are listed in the 'listOfSpecies' element of
 * the top-level Model object.  Lists of products, reactants and modifiers
 * in Reaction objects do not introduce new species, but rather, they refer
 * back to those listed in the model's top-level 'listOfSpecies'.  For
 * reactants and products, the connection is made using SpeciesReference
 * objects; for modifiers, it is made using ModifierSpeciesReference
 * objects.  SimpleSpeciesReference is an abstract type that serves as the
 * parent class of both SpeciesReference and ModifierSpeciesReference.  It
 * is used simply to hold the attributes and elements that are common to
 * the latter two structures.
 *
 * The SimpleSpeciesReference structure has a mandatory attribute,
 * 'species', which must be a text string conforming to the identifer
 * syntax permitted in %SBML.  This attribute is inherited by the
 * SpeciesReference and ModifierSpeciesReference subclasses derived from
 * SimpleSpeciesReference.  The value of the 'species' attribute must be
 * the identifier of a species defined in the enclosing Model.  The species
 * is thereby declared as participating in the reaction being defined.  The
 * precise role of that species as a reactant, product, or modifier in the
 * reaction is determined by the subclass of SimpleSpeciesReference (i.e.,
 * either SpeciesReference or ModifierSpeciesReference) in which the
 * identifier appears.
 * 
 * SimpleSpeciesReference also contains an optional attribute, 'id',
 * allowing instances to be referenced from other structures.  No SBML
 * structures currently do this; however, such structures are anticipated
 * in future SBML Levels.
 *
 *  
 */

public class SimpleSpeciesReference : SBase {
	private HandleRef swigCPtr;
	
	internal SimpleSpeciesReference(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.SimpleSpeciesReference_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.SimpleSpeciesReferenceUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(SimpleSpeciesReference obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (SimpleSpeciesReference obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~SimpleSpeciesReference() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_SimpleSpeciesReference(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/**
   * Returns the value of the 'id' attribute of this SimpleSpeciesReference.
   * 
   * @return the id of this SimpleSpeciesReference.
   */ public new
 string getId() {
    string ret = libsbmlPINVOKE.SimpleSpeciesReference_getId(swigCPtr);
    return ret;
  }

  
/**
   * Returns the value of the 'name' attribute of this SimpleSpeciesReference.
   * 
   * @return the name of this SimpleSpeciesReference.
   */ public new
 string getName() {
    string ret = libsbmlPINVOKE.SimpleSpeciesReference_getName(swigCPtr);
    return ret;
  }

  
/**
   * Get the value of the 'species' attribute.
   * 
   * @return the value of the attribute 'species' for this
   * SimpleSpeciesReference.
   */ public
 string getSpecies() {
    string ret = libsbmlPINVOKE.SimpleSpeciesReference_getSpecies(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * SimpleSpeciesReference's 'id' attribute is set.
   *
   * @return @c true if the 'id' attribute of this SimpleSpeciesReference is
   * set, @c false otherwise.
   */ public new
 bool isSetId() {
    bool ret = libsbmlPINVOKE.SimpleSpeciesReference_isSetId(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * SimpleSpeciesReference's 'name' attribute is set.
   *
   * @return @c true if the 'name' attribute of this SimpleSpeciesReference is
   * set, @c false otherwise.
   */ public new
 bool isSetName() {
    bool ret = libsbmlPINVOKE.SimpleSpeciesReference_isSetName(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * SimpleSpeciesReference's 'species' attribute is set.
   * 
   * @return @c true if the 'species' attribute of this
   * SimpleSpeciesReference is set, @c false otherwise.
   */ public
 bool isSetSpecies() {
    bool ret = libsbmlPINVOKE.SimpleSpeciesReference_isSetSpecies(swigCPtr);
    return ret;
  }

  
/**
   * Sets the 'species' attribute of this SimpleSpeciesReference.
   *
   * The identifier string passed in @p sid is copied.
   *
   * @param sid the identifier of a species defined in the enclosing
   * Model's ListOfSpecies.
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   */ public
 int setSpecies(string sid) {
    int ret = libsbmlPINVOKE.SimpleSpeciesReference_setSpecies(swigCPtr, sid);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Sets the value of the 'id' attribute of this SimpleSpeciesReference.
   *
   * The string @p sid is copied.  Note that SBML has strict requirements
   * for the syntax of identifiers.  @htmlinclude id-syntax.html
   *
   * @param sid the string to use as the identifier of this SimpleSpeciesReference
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE LIBSBML_UNEXPECTED_ATTRIBUTE @endlink
   */ public new
 int setId(string sid) {
    int ret = libsbmlPINVOKE.SimpleSpeciesReference_setId(swigCPtr, sid);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Sets the value of the 'name' attribute of this SimpleSpeciesReference.
   *
   * The string in @p name is copied.
   *
   * @param name the new name for the SimpleSpeciesReference
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE LIBSBML_UNEXPECTED_ATTRIBUTE @endlink
   */ public new
 int setName(string name) {
    int ret = libsbmlPINVOKE.SimpleSpeciesReference_setName(swigCPtr, name);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Unsets the value of the 'id' attribute of this SimpleSpeciesReference.
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   */ public new
 int unsetId() {
    int ret = libsbmlPINVOKE.SimpleSpeciesReference_unsetId(swigCPtr);
    return ret;
  }

  
/**
   * Unsets the value of the 'name' attribute of this SimpleSpeciesReference.
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   */ public new
 int unsetName() {
    int ret = libsbmlPINVOKE.SimpleSpeciesReference_unsetName(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * is a ModifierSpeciesReference.
   * 
   * @return @c true if this SimpleSpeciesReference's subclass is
   * ModiferSpeciesReference, @c false if it is a plain SpeciesReference.
   */ public
 bool isModifier() {
    bool ret = libsbmlPINVOKE.SimpleSpeciesReference_isModifier(swigCPtr);
    return ret;
  }

  
/**
   * Renames all the SIdRef attributes on this element, including any found in MathML
   */ public
 void renameSIdRefs(string oldid, string newid) {
    libsbmlPINVOKE.SimpleSpeciesReference_renameSIdRefs(swigCPtr, oldid, newid);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
