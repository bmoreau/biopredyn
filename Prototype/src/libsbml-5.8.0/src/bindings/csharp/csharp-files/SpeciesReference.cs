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
 * Implementation of %SBML's %SpeciesReference construct.
 *
 * The Reaction structure provides a way to express which species act as
 * reactants and which species act as products in a reaction.  In a given
 * reaction, references to those species acting as reactants and/or
 * products are made using instances of SpeciesReference structures in a
 * Reaction object's lists of reactants and products.
 *
 * A species can occur more than once in the lists of reactants and
 * products of a given Reaction instance.  The effective stoichiometry for
 * a species in a reaction is the sum of the stoichiometry values given on
 * the SpeciesReference object in the list of products minus the sum of
 * stoichiometry values given on the SpeciesReference objects in the list
 * of reactants.  A positive value indicates the species is effectively a
 * product and a negative value indicates the species is effectively a
 * reactant.  SBML places no restrictions on the effective stoichiometry of
 * a species in a reaction; for example, it can be zero.  In the following
 * SBML fragment, the two reactions have the same effective stoichiometry
 * for all their species:
 * <code>
 <reaction id='x'>
     <listOfReactants>
         <speciesReference species='a'/>
         <speciesReference species='a'/>
         <speciesReference species='b'/>
     </listOfReactants>
     <listOfProducts>
         <speciesReference species='c'/>
         <speciesReference species='b'/>
     </listProducts>
 </reaction>
 <reaction id='y'>
     <listOfReactants>
         <speciesReference species='a' stoichiometry='2'/>
     </listOfReactants>
     <listOfProducts>
         <speciesReference species='c'/>
     </listProducts>
 </reaction>
 </code>
 *
 * The precise structure of SpeciesReference differs between SBML
 * Level&nbsp;2 and Level&nbsp;3.  We discuss the two variants in separate
 * sections below.
 * 
 * @section spr-l2 SpeciesReference in SBML Level 2
 *
 * The mandatory 'species' attribute of SpeciesReference must have as its
 * value the identifier of an existing species defined in the enclosing
 * Model.  The species is thereby designated as a reactant or product in
 * the reaction.  Which one it is (i.e., reactant or product) is indicated
 * by whether the SpeciesReference appears in the Reaction's 'reactant' or
 * 'product' lists.
 * 
 * Product and reactant stoichiometries can be specified using
 * <em>either</em> 'stoichiometry' or 'stoichiometryMath' in a
 * SpeciesReference object.  The 'stoichiometry' attribute is of type
 * double and should contain values greater than zero (0).  The
 * 'stoichiometryMath' element is implemented as an element containing a
 * MathML expression.  These two are mutually exclusive; only one of
 * 'stoichiometry' or 'stoichiometryMath' should be defined in a given
 * SpeciesReference instance.  When neither the attribute nor the element
 * is present, the value of 'stoichiometry' in the SpeciesReference
 * instance defaults to @c 1.
 *
 * For maximum interoperability, the 'stoichiometry' attribute should be
 * used in preference to 'stoichiometryMath' when a species' stoichiometry
 * is a simple scalar number (integer or decimal).  When the stoichiometry
 * is a rational number, or when it is a more complicated formula,
 * 'stoichiometryMath' must be used.  The MathML expression in
 * 'stoichiometryMath' may also refer to identifiers of entities in a model
 * (except reaction identifiers).  However, the only species identifiers
 * that can be used in 'stoichiometryMath' are those referenced in the
 * Reaction list of reactants, products and modifiers.
 *
 * The following is a simple example of a species reference for species @c
 * X0, with stoichiometry @c 2, in a list of reactants within a reaction
 * having the identifier @c J1:
 * <code>
 <model>
     ...
     <listOfReactions>
         <reaction id='J1'>
             <listOfReactants>
                 <speciesReference species='X0' stoichiometry='2'>
             </listOfReactants>
             ...
         </reaction>
         ...
     </listOfReactions>
     ...
 </model>
 </code>
 *
 * The following is a more complex example of a species reference for
 * species X0, with a stoichiometry formula consisting of the parameter
 * @c x:
 * <code>
 <model>
     ...
     <listOfReactions>
         <reaction id='J1'>
             <listOfReactants>
                 <speciesReference species='X0'>
                     <stoichiometryMath>
                         <math xmlns='http://www.w3.org/1998/Math/MathML'>
                             <ci>x</ci>
                         </math>
                     </stoichiometryMath>
                 </speciesReference>
             </listOfReactants>
             ...
         </reaction>
         ...
     </listOfReactions>
     ...
 </model>
 </code>
 *
 *
 * @section spr-l3 SpeciesReference in SBML Level 3
 *
 * In Level 2's definition of a reaction, the stoichiometry attribute of a
 * SpeciesReference is actually a combination of two factors, the standard
 * biochemical stoichiometry and a conversion factor that may be needed to
 * translate the units of the species quantity to the units of the reaction
 * rate. Unfortunately, Level&nbsp;2 offers no direct way of decoupling
 * these two factors, or for explicitly indicating the units. The only way
 * to do it in Level&nbsp;2 is to use the StoichiometryMath object
 * associated with SpeciesReferences, and to reference SBML Parameter
 * objects from within the StoichiometryMath formula. This works because
 * Parameter offers a way to attach units to a numerical value, but the
 * solution is indirect and awkward for something that should be a simple
 * matter.  Moreover, the question of how to properly encode
 * stoichiometries in SBML reactions has caused much confusion among
 * implementors of SBML software.
 *
 * SBML Level&nbsp;3 approaches this problem differently.  It (1) extends
 * the the use of the SpeciesReference identifier to represent the value of
 * the 'stoichiometry' attribute, (2) makes the 'stoichiometry' attribute
 * optional, (3) removes StoichiometryMath, and (4) adds a new 'constant'
 * bool attribute on SpeciesReference.
 *
 * As in Level&nbsp;2, the 'stoichiometry' attribute is of type
 * @c double and should contain values greater than zero (@c 0).  A
 * missing 'stoichiometry' implies that the stoichiometry is either
 * unknown, or to be obtained from an external source, or determined by an
 * InitialAssignment object or other SBML construct elsewhere in the model.
 *
 * A species reference's stoichiometry is set by its 'stoichiometry'
 * attribute exactly once.  If the SpeciesReference object's 'constant'
 * attribute has the value @c true, then the stoichiometry is fixed and
 * cannot be changed except by an InitialAssignment object.  These two
 * methods of setting the stoichiometry (i.e., using 'stoichiometry'
 * directly, or using InitialAssignment) differ in that the 'stoichiometry'
 * attribute can only be set to a literal floating-point number, whereas
 * InitialAssignment allows the value to be set using an arbitrary
 * mathematical expression.  (As an example, the approach could be used to
 * set the stoichiometry to a rational number of the form @em p/@em q,
 * where @em p and @em q are integers, something that is occasionally
 * useful in the context of biochemical reaction networks.)  If the species
 * reference's 'constant' attribute has the value @c false, the species
 * reference's value may be overridden by an InitialAssignment or changed
 * by AssignmentRule or AlgebraicRule, and in addition, for simulation time
 * <em>t &gt; 0</em>, it may also be changed by a RateRule or Event
 * objects.  (However, some of these constructs are mutually exclusive; see
 * the SBML Level&nbsp;3 Version&nbsp;1 Core specifiation for more
 * details.)  It is not an error to define 'stoichiometry' on a species
 * reference and also redefine the stoichiometry using an
 * InitialAssignment, but the 'stoichiometry' attribute in that case is
 * ignored.
 *
 * The value of the 'id' attribute of a SpeciesReference can be used as the
 * content of a <c>&lt;ci&gt;</c> element in MathML formulas
 * elsewhere in the model.  When the identifier appears in a MathML
 * <c>&lt;ci&gt;</c> element, it represents the stoichiometry of the
 * corresponding species in the reaction where the SpeciesReference object
 * instance appears.  More specifically, it represents the value of the
 * 'stoichiometry' attribute on the SpeciesReference object.
 *
 * In SBML Level 3, the unit of measurement associated with the value of a
 * species' stoichiometry is always considered to be @c dimensionless.
 * This has the following implications:
 * <ul>
 *
 * <li> When a species reference's identifier appears in mathematical
 * formulas elsewhere in the model, the unit associated with that value is
 * @c dimensionless.
 *
 * <li> The units of the 'math' elements of AssignmentRule,
 * InitialAssignment and EventAssignment objects setting the stoichiometry
 * of the species reference should be @c dimensionless.
 *
 * <li> If a species reference's identifier is the subject of a RateRule,
 * the unit associated with the RateRule object's value should be
 * <c>dimensionless</c>/<em>time</em>, where <em>time</em> is the
 * model-wide unit of time set on the Model object.
 *
 * </ul>
 * 
 * <!---------------------------------------------------------------------- -->
 *
 */

public class SpeciesReference : SimpleSpeciesReference {
	private HandleRef swigCPtr;
	
	internal SpeciesReference(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.SpeciesReference_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.SpeciesReferenceUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(SpeciesReference obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (SpeciesReference obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~SpeciesReference() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_SpeciesReference(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/**
   * Creates a new SpeciesReference using the given SBML @p level and @p version
   * values.
   *
   * @param level a long integer, the SBML Level to assign to this SpeciesReference
   *
   * @param version a long integer, the SBML Version to assign to this
   * SpeciesReference
   * 
   * @note Upon the addition of a SpeciesReference object to a Model (e.g.,
   * using Reaction::addReactant(SpeciesReference sr) or
   * Reaction::addProduct(SpeciesReference sr)), the SBML Level,
   * SBML Version and XML namespace of the document @em override the values
   * used when creating the SpeciesReference object via this constructor.
   * This is necessary to ensure that an SBML document is a consistent
   * structure.  Nevertheless, the ability to supply the values at the time
   * of creation of a SpeciesReference is an important aid to producing
   * valid SBML.  Knowledge of the intented SBML Level and Version
   * determine whether it is valid to assign a particular value to an
   * attribute, or whether it is valid to add an object to an existing
   * SBMLDocument.
   */ public
 SpeciesReference(long level, long version) : this(libsbmlPINVOKE.new_SpeciesReference__SWIG_0(level, version), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new SpeciesReference using the given SBMLNamespaces object
   * @p sbmlns.
   *
   * @param sbmlns an SBMLNamespaces object.
   *
   * @note Upon the addition of a SpeciesReference object to a Model (e.g.,
   * using Reaction::addReactant(SpeciesReference sr) or
   * Reaction::addProduct(SpeciesReference sr)), the SBML Level,
   * SBML Version and XML namespace of the document @em override the values
   * used when creating the SpeciesReference object via this constructor.
   * This is necessary to ensure that an SBML document is a consistent
   * structure.  Nevertheless, the ability to supply the values at the time
   * of creation of a SpeciesReference is an important aid to producing
   * valid SBML.  Knowledge of the intented SBML Level and Version
   * determine whether it is valid to assign a particular value to an
   * attribute, or whether it is valid to add an object to an existing
   * SBMLDocument.
   */ public
 SpeciesReference(SBMLNamespaces sbmlns) : this(libsbmlPINVOKE.new_SpeciesReference__SWIG_1(SBMLNamespaces.getCPtr(sbmlns)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Copy constructor; creates a copy of this SpeciesReference.
   * 
   * @param orig the SpeciesReference instance to copy.
   *
   * @throws @if python ValueError @else SBMLConstructorException @endif@~
   * Thrown if the argument @p orig is @c null.
   */ public
 SpeciesReference(SpeciesReference orig) : this(libsbmlPINVOKE.new_SpeciesReference__SWIG_2(SpeciesReference.getCPtr(orig)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this SpeciesReference instance.
   *
   * @return a (deep) copy of this SpeciesReference.
   */ public new
 SpeciesReference clone() {
    IntPtr cPtr = libsbmlPINVOKE.SpeciesReference_clone(swigCPtr);
    SpeciesReference ret = (cPtr == IntPtr.Zero) ? null : new SpeciesReference(cPtr, true);
    return ret;
  }

  
/**
   * Initializes the fields of this SpeciesReference object to 'typical'
   * default values.
   *
   * The SBML SpeciesReference component has slightly different aspects and
   * default attribute values in different SBML Levels and Versions.
   * This method sets the values to certain common defaults, based
   * mostly on what they are in SBML Level&nbsp;2.  Specifically:
   * <ul>
   * <li> Sets attribute 'stoichiometry' to @c 1.0
   * <li> (Applies to Level&nbsp;1 models only) Sets attribute 'denominator' to @c 1
   * </ul>
   *
   * @see getDenominator()
   * @see setDenominator(int value)
   * @see getStoichiometry()
   * @see setStoichiometry(double value)
   * @see getStoichiometryMath()
   * @see setStoichiometryMath(StoichiometryMath math)
   */ public
 void initDefaults() {
    libsbmlPINVOKE.SpeciesReference_initDefaults(swigCPtr);
  }

  
/**
   * Get the value of the 'stoichiometry' attribute.
   *
   * In SBML Level 2, product and reactant stoichiometries can be specified
   * using <em>either</em> 'stoichiometry' or 'stoichiometryMath' in a
   * SpeciesReference object.  The former is to be used when a
   * stoichiometry is simply a scalar number, while the latter is for
   * occasions when it needs to be a rational number or it needs to
   * reference other mathematical expressions.  The 'stoichiometry'
   * attribute is of type @c double and should contain values greater than
   * zero (@c 0).  The 'stoichiometryMath' element is implemented as an
   * element containing a MathML expression.  These two are mutually
   * exclusive; only one of 'stoichiometry' or 'stoichiometryMath' should
   * be defined in a given SpeciesReference instance.  When neither the
   * attribute nor the element is present, the value of 'stoichiometry' in
   * the SpeciesReference instance defaults to @c 1.  For maximum
   * interoperability between different software tools, the 'stoichiometry'
   * attribute should be used in preference to 'stoichiometryMath' when a
   * species' stoichiometry is a simple scalar number (integer or
   * decimal).
   *
   * In SBML Level 3, there is no StoichiometryMath, and SpeciesReference
   * objects have only the 'stoichiometry' attribute.
   * 
   * @return the value of the (scalar) 'stoichiometry' attribute of this
   * SpeciesReference.
   *
   * @see getStoichiometryMath()
   */ public
 double getStoichiometry() {
    double ret = libsbmlPINVOKE.SpeciesReference_getStoichiometry(swigCPtr);
    return ret;
  }

  
/**
   * Get the content of the 'stoichiometryMath' subelement as an ASTNode
   * tree.
   *
   * The 'stoichiometryMath' element exists only in SBML Level 2.  There,
   * product and reactant stoichiometries can be specified using
   * <em>either</em> 'stoichiometry' or 'stoichiometryMath' in a
   * SpeciesReference object.  The former is to be used when a
   * stoichiometry is simply a scalar number, while the latter is for
   * occasions when it needs to be a rational number or it needs to
   * reference other mathematical expressions.  The 'stoichiometry'
   * attribute is of type @c double and should contain values greater than
   * zero (@c 0).  The 'stoichiometryMath' element is implemented as an
   * element containing a MathML expression.  These two are mutually
   * exclusive; only one of 'stoichiometry' or 'stoichiometryMath' should
   * be defined in a given SpeciesReference instance.  When neither the
   * attribute nor the element is present, the value of 'stoichiometry' in
   * the SpeciesReference instance defaults to @c 1.  For maximum
   * interoperability between different software tools, the 'stoichiometry'
   * attribute should be used in preference to 'stoichiometryMath' when a
   * species' stoichiometry is a simple scalar number (integer or decimal).
   * 
   * @return the content of the 'stoichiometryMath' subelement of this
   * SpeciesReference.
   */ public
 StoichiometryMath getStoichiometryMath() {
    IntPtr cPtr = libsbmlPINVOKE.SpeciesReference_getStoichiometryMath__SWIG_0(swigCPtr);
    StoichiometryMath ret = (cPtr == IntPtr.Zero) ? null : new StoichiometryMath(cPtr, false);
    return ret;
  }

  
/**
   * Get the value of the 'denominator' attribute, for the case of a
   * rational-numbered stoichiometry or a model in SBML Level&nbsp;1.
   *
   * The 'denominator' attribute is only actually written out in the case
   * of an SBML Level&nbsp;1 model.  In SBML Level&nbsp;2, rational-number
   * stoichiometries are written as MathML elements in the
   * 'stoichiometryMath' subelement.  However, as a convenience to users,
   * libSBML allows the creation and manipulation of rational-number
   * stoichiometries by supplying the numerator and denominator directly
   * rather than having to manually create an ASTNode structure.  LibSBML
   * will write out the appropriate constructs (either a combination of
   * 'stoichiometry' and 'denominator' in the case of SBML Level&nbsp;1, or a
   * 'stoichiometryMath' subelement in the case of SBML Level&nbsp;2).
   * 
   * @return the value of the 'denominator' attribute of this
   * SpeciesReference.
   */ public
 int getDenominator() {
    int ret = libsbmlPINVOKE.SpeciesReference_getDenominator(swigCPtr);
    return ret;
  }

  
/**
   * Get the value of the 'constant' attribute.
   * 
   * @return the value of the 'constant' attribute of this
   * SpeciesReference.
   */ public
 bool getConstant() {
    bool ret = libsbmlPINVOKE.SpeciesReference_getConstant(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * SpeciesReference's 'stoichiometryMath' subelement is set
   * 
   * @return @c true if the 'stoichiometryMath' subelement of this
   * SpeciesReference is set, @c false otherwise.
   */ public
 bool isSetStoichiometryMath() {
    bool ret = libsbmlPINVOKE.SpeciesReference_isSetStoichiometryMath(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * SpeciesReference's 'constant' attribute is set
   * 
   * @return @c true if the 'constant' attribute of this
   * SpeciesReference is set, @c false otherwise.
   */ public
 bool isSetConstant() {
    bool ret = libsbmlPINVOKE.SpeciesReference_isSetConstant(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * SpeciesReference's 'stoichiometry' attribute is set.
   * 
   * @return @c true if the 'stoichiometry' attribute of this
   * SpeciesReference is set, @c false otherwise.
   */ public
 bool isSetStoichiometry() {
    bool ret = libsbmlPINVOKE.SpeciesReference_isSetStoichiometry(swigCPtr);
    return ret;
  }

  
/**
   * Sets the value of the 'stoichiometry' attribute of this
   * SpeciesReference.
   *
   * In SBML Level 2, product and reactant stoichiometries can be specified
   * using <em>either</em> 'stoichiometry' or 'stoichiometryMath' in a
   * SpeciesReference object.  The former is to be used when a
   * stoichiometry is simply a scalar number, while the latter is for
   * occasions when it needs to be a rational number or it needs to
   * reference other mathematical expressions.  The 'stoichiometry'
   * attribute is of type @c double and should contain values greater than
   * zero (@c 0).  The 'stoichiometryMath' element is implemented as an
   * element containing a MathML expression.  These two are mutually
   * exclusive; only one of 'stoichiometry' or 'stoichiometryMath' should
   * be defined in a given SpeciesReference instance.  When neither the
   * attribute nor the element is present, the value of 'stoichiometry' in
   * the SpeciesReference instance defaults to @c 1.  For maximum
   * interoperability between different software tools, the 'stoichiometry'
   * attribute should be used in preference to 'stoichiometryMath' when a
   * species' stoichiometry is a simple scalar number (integer or
   * decimal).
   *
   * In SBML Level 3, there is no StoichiometryMath, and SpeciesReference
   * objects have only the 'stoichiometry' attribute.
   * 
   * @param value the new value of the 'stoichiometry' attribute
   *
   * @note In SBML Level&nbsp;2, the 'stoichiometryMath' subelement of this
   * SpeciesReference object will be unset because the 'stoichiometry'
   * attribute and the stoichiometryMath' subelement are mutually
   * exclusive.
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   */ public
 int setStoichiometry(double value) {
    int ret = libsbmlPINVOKE.SpeciesReference_setStoichiometry(swigCPtr, value);
    return ret;
  }

  
/**
   * Sets the 'stoichiometryMath' subelement of this SpeciesReference.
   *
   * The Abstract Syntax Tree in @p math is copied.
   *
   * In SBML Level 2, product and reactant stoichiometries can be specified
   * using <em>either</em> 'stoichiometry' or 'stoichiometryMath' in a
   * SpeciesReference object.  The former is to be used when a
   * stoichiometry is simply a scalar number, while the latter is for
   * occasions when it needs to be a rational number or it needs to
   * reference other mathematical expressions.  The 'stoichiometry'
   * attribute is of type @c double and should contain values greater than
   * zero (@c 0).  The 'stoichiometryMath' element is implemented as an
   * element containing a MathML expression.  These two are mutually
   * exclusive; only one of 'stoichiometry' or 'stoichiometryMath' should
   * be defined in a given SpeciesReference instance.  When neither the
   * attribute nor the element is present, the value of 'stoichiometry' in
   * the SpeciesReference instance defaults to @c 1.  For maximum
   * interoperability between different software tools, the 'stoichiometry'
   * attribute should be used in preference to 'stoichiometryMath' when a
   * species' stoichiometry is a simple scalar number (integer or
   * decimal).
   *
   * In SBML Level 3, there is no StoichiometryMath, and SpeciesReference
   * objects have only the 'stoichiometry' attribute.
   * 
   * @param math the StoichiometryMath expression that is to be copied as the
   * content of the 'stoichiometryMath' subelement.
   *
   * @note In SBML Level&nbsp;2, the 'stoichiometry' attribute of this
   * SpeciesReference object will be unset (isSetStoichiometry() will
   * return @c false although getStoichiometry() will return @c 1.0) if the
   * given math is not null because the 'stoichiometry' attribute and the
   * stoichiometryMath' subelement are mutually exclusive.
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE LIBSBML_UNEXPECTED_ATTRIBUTE @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_LEVEL_MISMATCH LIBSBML_LEVEL_MISMATCH @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_VERSION_MISMATCH LIBSBML_VERSION_MISMATCH @endlink
   */ public
 int setStoichiometryMath(StoichiometryMath math) {
    int ret = libsbmlPINVOKE.SpeciesReference_setStoichiometryMath(swigCPtr, StoichiometryMath.getCPtr(math));
    return ret;
  }

  
/**
   * Set the value of the 'denominator' attribute, for the case of a
   * rational-numbered stoichiometry or a model in SBML Level&nbsp;1.
   *
   * The 'denominator' attribute is only actually written out in the case
   * of an SBML Level&nbsp;1 model.  In SBML Level&nbsp;2, rational-number
   * stoichiometries are written as MathML elements in the
   * 'stoichiometryMath' subelement.  However, as a convenience to users,
   * libSBML allows the creation and manipulation of rational-number
   * stoichiometries by supplying the numerator and denominator directly
   * rather than having to manually create an ASTNode structure.  LibSBML
   * will write out the appropriate constructs (either a combination of
   * 'stoichiometry' and 'denominator' in the case of SBML Level&nbsp;1, or
   * a 'stoichiometryMath' subelement in the case of SBML Level&nbsp;2).
   *
   * @param value the scalar value 
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   */ public
 int setDenominator(int value) {
    int ret = libsbmlPINVOKE.SpeciesReference_setDenominator(swigCPtr, value);
    return ret;
  }

  
/**
   * Sets the 'constant' attribute of this SpeciesReference to the given bool
   * @p flag.
   *
   * @param flag a bool, the value for the 'constant' attribute of this
   * SpeciesReference instance
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE LIBSBML_UNEXPECTED_ATTRIBUTE @endlink
   */ public
 int setConstant(bool flag) {
    int ret = libsbmlPINVOKE.SpeciesReference_setConstant(swigCPtr, flag);
    return ret;
  }

  
/**
   * Unsets the 'stoichiometryMath' subelement of this SpeciesReference.
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE LIBSBML_UNEXPECTED_ATTRIBUTE @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   *
   * In SBML Level 2, product and reactant stoichiometries can be specified
   * using <em>either</em> 'stoichiometry' or 'stoichiometryMath' in a
   * SpeciesReference object.  The former is to be used when a
   * stoichiometry is simply a scalar number, while the latter is for
   * occasions when it needs to be a rational number or it needs to
   * reference other mathematical expressions.  The 'stoichiometry'
   * attribute is of type @c double and should contain values greater than
   * zero (@c 0).  The 'stoichiometryMath' element is implemented as an
   * element containing a MathML expression.  These two are mutually
   * exclusive; only one of 'stoichiometry' or 'stoichiometryMath' should
   * be defined in a given SpeciesReference instance.  When neither the
   * attribute nor the element is present, the value of 'stoichiometry' in
   * the SpeciesReference instance defaults to @c 1.  For maximum
   * interoperability between different software tools, the 'stoichiometry'
   * attribute should be used in preference to 'stoichiometryMath' when a
   * species' stoichiometry is a simple scalar number (integer or
   * decimal).
   *
   * In SBML Level 3, there is no StoichiometryMath, and SpeciesReference
   * objects have only the 'stoichiometry' attribute.
   *
   * @note In SBML Level&nbsp;2, the 'stoichiometry' attribute of this
   * SpeciesReference object will be reset to a default value (@c 1.0) if
   * the 'stoichiometry' attribute has not been set.
   */ public
 int unsetStoichiometryMath() {
    int ret = libsbmlPINVOKE.SpeciesReference_unsetStoichiometryMath(swigCPtr);
    return ret;
  }

  
/**
   * Unsets the 'stoichiometry' attribute of this SpeciesReference.
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   *
   * @note In SBML Level&nbsp;1, the 'stoichiometry' attribute of this
   * SpeciesReference object will be just reset to a default value (@c 1.0)
   * and isSetStoichiometry() will still return @c true.  In SBML
   * Level&nbsp;2, the 'stoichiometry' attribute of this object will be
   * unset (which will result in isSetStoichiometry() returning @c false,
   * although getStoichiometry() will return @c 1.0) if the
   * 'stoichiometryMath' subelement is set, otherwise the attribute
   * will be just reset to the default value (@c 1.0) (and
   * isSetStoichiometry() will still return @c true).  In SBML
   * Level&nbsp;3, the 'stoichiometry' attribute of this object will be set
   * to @c NaN and isSetStoichiometry() will return @c false.
   */ public
 int unsetStoichiometry() {
    int ret = libsbmlPINVOKE.SpeciesReference_unsetStoichiometry(swigCPtr);
    return ret;
  }

  
/**
   * Creates a new, empty StoichiometryMath object, adds it to this
   * SpeciesReference, and returns it.
   *
   * @return the newly created StoichiometryMath object instance
   *
   * @see Reaction::addReactant(SpeciesReference sr)
   * @see Reaction::addProduct(SpeciesReference sr)
   */ public
 StoichiometryMath createStoichiometryMath() {
    IntPtr cPtr = libsbmlPINVOKE.SpeciesReference_createStoichiometryMath(swigCPtr);
    StoichiometryMath ret = (cPtr == IntPtr.Zero) ? null : new StoichiometryMath(cPtr, false);
    return ret;
  }

  
/**
   * Sets the value of the 'annotation' subelement of this SBML object to a
   * copy of @p annotation.
   *
   * Any existing content of the 'annotation' subelement is discarded.
   * Unless you have taken steps to first copy and reconstitute any
   * existing annotations into the @p annotation that is about to be
   * assigned, it is likely that performing such wholesale replacement is
   * unfriendly towards other software applications whose annotations are
   * discarded.  An alternative may be to use appendAnnotation().
   *
   * @param annotation an XML structure that is to be used as the content
   * of the 'annotation' subelement of this object
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   *
   * @see appendAnnotation(XMLNode annotation)
   * @see appendAnnotation(string annotation)
   */ public new
 int setAnnotation(XMLNode annotation) {
    int ret = libsbmlPINVOKE.SpeciesReference_setAnnotation__SWIG_0(swigCPtr, XMLNode.getCPtr(annotation));
    return ret;
  }

  
/**
   * Sets the value of the 'annotation' subelement of this SBML object to a
   * copy of @p annotation.
   *
   * Any existing content of the 'annotation' subelement is discarded.
   * Unless you have taken steps to first copy and reconstitute any
   * existing annotations into the @p annotation that is about to be
   * assigned, it is likely that performing such wholesale replacement is
   * unfriendly towards other software applications whose annotations are
   * discarded.  An alternative may be to use appendAnnotation().
   *
   * @param annotation an XML string that is to be used as the content
   * of the 'annotation' subelement of this object
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   *
   * @see appendAnnotation(XMLNode annotation)
   * @see appendAnnotation(string annotation)
   */ public new
 int setAnnotation(string annotation) {
    int ret = libsbmlPINVOKE.SpeciesReference_setAnnotation__SWIG_1(swigCPtr, annotation);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Appends annotation content to any existing content in the 'annotation'
   * subelement of this object.
   *
   * The content in @p annotation is copied.  Unlike
   * SpeciesReference::setAnnotation(@if java String annotation@endif),
   * this method allows other annotations to be preserved when an application
   * adds its own data.
   *
   * @param annotation an XML structure that is to be copied and appended
   * to the content of the 'annotation' subelement of this object
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   *
   * @see setAnnotation(string annotation)
   * @see setAnnotation(XMLNode annotation)
   */ public new
 int appendAnnotation(XMLNode annotation) {
    int ret = libsbmlPINVOKE.SpeciesReference_appendAnnotation__SWIG_0(swigCPtr, XMLNode.getCPtr(annotation));
    return ret;
  }

  
/**
   * Appends annotation content to any existing content in the 'annotation'
   * subelement of this object.
   *
   * The content in @p annotation is copied.  Unlike
   * SpeciesReference::setAnnotation(@if java String annotation@endif), this
   * method allows other annotations to be preserved when an application
   * adds its own data.
   *
   * @param annotation an XML string that is to be copied and appended
   * to the content of the 'annotation' subelement of this object
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   *
   * @see setAnnotation(string annotation)
   * @see setAnnotation(XMLNode annotation)
   */ public new
 int appendAnnotation(string annotation) {
    int ret = libsbmlPINVOKE.SpeciesReference_appendAnnotation__SWIG_1(swigCPtr, annotation);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
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
    int ret = libsbmlPINVOKE.SpeciesReference_getTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the XML element name of this object, which for
   * SpeciesReference, is always @c 'speciesReference'.
   * 
   * @return the name of this element, i.e., @c 'speciesReference'.
   */ public new
 string getElementName() {
    string ret = libsbmlPINVOKE.SpeciesReference_getElementName(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if
   * all the required attributes for this SpeciesReference object
   * have been set.
   *
   * @note The required attributes for a SpeciesReference object are:
   * @li 'species'
   * @li 'constant' (only available SBML Level&nbsp;3)
   *
   * @return a bool value indicating whether all the required
   * attributes for this object have been defined.
   */ public new
 bool hasRequiredAttributes() {
    bool ret = libsbmlPINVOKE.SpeciesReference_hasRequiredAttributes(swigCPtr);
    return ret;
  }

}

}
