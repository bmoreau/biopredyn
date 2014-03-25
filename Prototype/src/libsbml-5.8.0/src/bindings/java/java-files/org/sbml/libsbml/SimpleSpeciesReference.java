/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.6
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.sbml.libsbml;

/** 
 * 
 * Implementation of SBML's SimpleSpeciesReference construct.
 * <p>
 * As mentioned in the description of {@link Reaction}, every species that enters
 * into a given reaction must appear in that reaction's lists of reactants,
 * products and/or modifiers.  In an SBML model, all species that may
 * participate in any reaction are listed in the 'listOfSpecies' element of
 * the top-level {@link Model} object.  Lists of products, reactants and modifiers
 * in {@link Reaction} objects do not introduce new species, but rather, they refer
 * back to those listed in the model's top-level 'listOfSpecies'.  For
 * reactants and products, the connection is made using {@link SpeciesReference}
 * objects; for modifiers, it is made using {@link ModifierSpeciesReference}
 * objects.  {@link SimpleSpeciesReference} is an abstract type that serves as the
 * parent class of both {@link SpeciesReference} and {@link ModifierSpeciesReference}.  It
 * is used simply to hold the attributes and elements that are common to
 * the latter two structures.
 * <p>
 * The {@link SimpleSpeciesReference} structure has a mandatory attribute,
 * 'species', which must be a text string conforming to the identifer
 * syntax permitted in SBML.  This attribute is inherited by the
 * {@link SpeciesReference} and {@link ModifierSpeciesReference} subclasses derived from
 * {@link SimpleSpeciesReference}.  The value of the 'species' attribute must be
 * the identifier of a species defined in the enclosing {@link Model}.  The species
 * is thereby declared as participating in the reaction being defined.  The
 * precise role of that species as a reactant, product, or modifier in the
 * reaction is determined by the subclass of {@link SimpleSpeciesReference} (i.e.,
 * either {@link SpeciesReference} or {@link ModifierSpeciesReference}) in which the
 * identifier appears.
 * <p>
 * {@link SimpleSpeciesReference} also contains an optional attribute, 'id',
 * allowing instances to be referenced from other structures.  No SBML
 * structures currently do this; however, such structures are anticipated
 * in future SBML Levels.
 * <p>
 * <p>
 */

public class SimpleSpeciesReference extends SBase {
   private long swigCPtr;

   protected SimpleSpeciesReference(long cPtr, boolean cMemoryOwn)
   {
     super(libsbmlJNI.SimpleSpeciesReference_SWIGUpcast(cPtr), cMemoryOwn);
     swigCPtr = cPtr;
   }

   protected static long getCPtr(SimpleSpeciesReference obj)
   {
     return (obj == null) ? 0 : obj.swigCPtr;
   }

   protected static long getCPtrAndDisown (SimpleSpeciesReference obj)
   {
     long ptr = 0;

     if (obj != null)
     {
       ptr             = obj.swigCPtr;
       obj.swigCMemOwn = false;
     }

     return ptr;
   }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libsbmlJNI.delete_SimpleSpeciesReference(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  
/**
   * Returns the value of the 'id' attribute of this {@link SimpleSpeciesReference}.
   * <p>
   * @return the id of this {@link SimpleSpeciesReference}.
   */ public
 String getId() {
    return libsbmlJNI.SimpleSpeciesReference_getId(swigCPtr, this);
  }

  
/**
   * Returns the value of the 'name' attribute of this {@link SimpleSpeciesReference}.
   * <p>
   * @return the name of this {@link SimpleSpeciesReference}.
   */ public
 String getName() {
    return libsbmlJNI.SimpleSpeciesReference_getName(swigCPtr, this);
  }

  
/**
   * Get the value of the 'species' attribute.
   * <p>
   * @return the value of the attribute 'species' for this
   * {@link SimpleSpeciesReference}.
   */ public
 String getSpecies() {
    return libsbmlJNI.SimpleSpeciesReference_getSpecies(swigCPtr, this);
  }

  
/**
   * Predicate returning <code>true</code> if this
   * {@link SimpleSpeciesReference}'s 'id' attribute is set.
   * <p>
   * @return <code>true</code> if the 'id' attribute of this {@link SimpleSpeciesReference} is
   * set, <code>false</code> otherwise.
   */ public
 boolean isSetId() {
    return libsbmlJNI.SimpleSpeciesReference_isSetId(swigCPtr, this);
  }

  
/**
   * Predicate returning <code>true</code> if this
   * {@link SimpleSpeciesReference}'s 'name' attribute is set.
   * <p>
   * @return <code>true</code> if the 'name' attribute of this {@link SimpleSpeciesReference} is
   * set, <code>false</code> otherwise.
   */ public
 boolean isSetName() {
    return libsbmlJNI.SimpleSpeciesReference_isSetName(swigCPtr, this);
  }

  
/**
   * Predicate returning <code>true</code> if this
   * {@link SimpleSpeciesReference}'s 'species' attribute is set.
   * <p>
   * @return <code>true</code> if the 'species' attribute of this
   * {@link SimpleSpeciesReference} is set, <code>false</code> otherwise.
   */ public
 boolean isSetSpecies() {
    return libsbmlJNI.SimpleSpeciesReference_isSetSpecies(swigCPtr, this);
  }

  
/**
   * Sets the 'species' attribute of this {@link SimpleSpeciesReference}.
   * <p>
   * The identifier string passed in <code>sid</code> is copied.
   * <p>
   * @param sid the identifier of a species defined in the enclosing
   * {@link Model}'s {@link ListOfSpecies}.
   * <p>
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * <li> {@link  libsbmlConstants#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE }
   * </ul>
   */ public
 int setSpecies(String sid) {
    return libsbmlJNI.SimpleSpeciesReference_setSpecies(swigCPtr, this, sid);
  }

  
/**
   * Sets the value of the 'id' attribute of this {@link SimpleSpeciesReference}.
   * <p>
   * The string <code>sid</code> is copied.  Note that SBML has strict requirements
   * for the syntax of identifiers.  The following is a summary of the definition of the SBML identifier type 
<code>SId</code>, which defines the permitted syntax of identifiers.  We
express the syntax using an extended form of BNF notation: 
<pre style='margin-left: 2em; border: none; font-weight: bold; font-size: 13px; color: black'>
letter .= 'a'..'z','A'..'Z'
digit  .= '0'..'9'
idChar .= letter | digit | '_'
SId    .= ( letter | '_' ) idChar*
</pre>
The characters <code>(</code> and <code>)</code> are used for grouping, the
character <code>*</code> 'zero or more times', and the character
<code>|</code> indicates logical 'or'.  The equality of SBML identifiers is
determined by an exact character sequence match; i.e., comparisons must be
performed in a case-sensitive manner.  In addition, there are a few
conditions for the uniqueness of identifiers in an SBML model.  Please
consult the SBML specifications for the exact formulations.
<p>

   * <p>
   * @param sid the string to use as the identifier of this {@link SimpleSpeciesReference}
   * <p>
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * <li> {@link  libsbmlConstants#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE }
   * <li> {@link  libsbmlConstants#LIBSBML_UNEXPECTED_ATTRIBUTE LIBSBML_UNEXPECTED_ATTRIBUTE }
   * </ul>
   */ public
 int setId(String sid) {
    return libsbmlJNI.SimpleSpeciesReference_setId(swigCPtr, this, sid);
  }

  
/**
   * Sets the value of the 'name' attribute of this {@link SimpleSpeciesReference}.
   * <p>
   * The string in <code>name</code> is copied.
   * <p>
   * @param name the new name for the {@link SimpleSpeciesReference}
   * <p>
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * <li> {@link  libsbmlConstants#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE }
   * <li> {@link  libsbmlConstants#LIBSBML_UNEXPECTED_ATTRIBUTE LIBSBML_UNEXPECTED_ATTRIBUTE }
   * </ul>
   */ public
 int setName(String name) {
    return libsbmlJNI.SimpleSpeciesReference_setName(swigCPtr, this, name);
  }

  
/**
   * Unsets the value of the 'id' attribute of this {@link SimpleSpeciesReference}.
   * <p>
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED }
   * </ul>
   */ public
 int unsetId() {
    return libsbmlJNI.SimpleSpeciesReference_unsetId(swigCPtr, this);
  }

  
/**
   * Unsets the value of the 'name' attribute of this {@link SimpleSpeciesReference}.
   * <p>
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED }
   * </ul>
   */ public
 int unsetName() {
    return libsbmlJNI.SimpleSpeciesReference_unsetName(swigCPtr, this);
  }

  
/**
   * Predicate returning <code>true</code> if this
   * is a {@link ModifierSpeciesReference}.
   * <p>
   * @return <code>true</code> if this {@link SimpleSpeciesReference}'s subclass is
   * ModiferSpeciesReference, <code>false</code> if it is a plain {@link SpeciesReference}.
   */ public
 boolean isModifier() {
    return libsbmlJNI.SimpleSpeciesReference_isModifier(swigCPtr, this);
  }

  
/**
   * Renames all the SIdRef attributes on this element, including any found in MathML
   */ public
 void renameSIdRefs(String oldid, String newid) {
    libsbmlJNI.SimpleSpeciesReference_renameSIdRefs(swigCPtr, this, oldid, newid);
  }

}
