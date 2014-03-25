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
 * Implementation of %SBML's %Rule construct.
 *
 * In SBML, @em rules provide additional ways to define the values of
 * variables in a model, their relationships, and the dynamical behaviors
 * of those variables.  They enable encoding relationships that cannot be
 * expressed using Reaction nor InitialAssignment objects alone.
 *
 * The libSBML implementation of rules mirrors the SBML Level&nbsp;3
 * Version&nbsp;1 Core definition (which is in turn is very similar to the
 * Level&nbsp;2 Version&nbsp;4 definition), with Rule being the parent
 * class of three subclasses as explained below.  The Rule class itself
 * cannot be instantiated by user programs and has no constructor; only the
 * subclasses AssignmentRule, AlgebraicRule and RateRule can be
 * instantiated directly.
 *
 * @section general General summary of SBML rules
 *
 * @htmlinclude rules-general-summary.html
 * 
 * @section additional-restrictions Additional restrictions on SBML rules
 * 
 * @htmlinclude rules-additional-restrictions.html
 * 
 * @section RuleType_t Rule types for SBML Level 1
 *
 * SBML Level 1 uses a different scheme than SBML Level 2 and Level 3 for
 * distinguishing rules; specifically, it uses an attribute whose value is
 * drawn from an enumeration of 3 values.  LibSBML supports this using methods
 * that work @if clike a libSBML enumeration type, RuleType_t, whose values
 * are @else with the enumeration values @endif@~ listed below.
 *
 * @li @link libsbmlcs.libsbml.RULE_TYPE_RATE RULE_TYPE_RATE@endlink: Indicates
 * the rule is a 'rate' rule.
 * @li @link libsbmlcs.libsbml.RULE_TYPE_SCALAR RULE_TYPE_SCALAR@endlink:
 * Indicates the rule is a 'scalar' rule.
 * @li @link libsbmlcs.libsbml.RULE_TYPE_INVALID RULE_TYPE_INVALID@endlink:
 * Indicates the rule type is unknown or not yet set.
 *
 * <!-- leave this next break as-is to work around some doxygen bug -->
 */

public class Rule : SBase {
	private HandleRef swigCPtr;
	
	internal Rule(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.Rule_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.RuleUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(Rule obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (Rule obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~Rule() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_Rule(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/**
   * Copy constructor; creates a copy of this Rule.
   *
   * @param orig the object to copy.
   * 
   * @throws @if python ValueError @else SBMLConstructorException @endif@~
   * Thrown if the argument @p orig is @c null.
   */ public
 Rule(Rule orig) : this(libsbmlPINVOKE.new_Rule(Rule.getCPtr(orig)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this Rule.
   * 
   * @return a (deep) copy of this Rule.
   */ public new
 Rule clone() {
        Rule ret = (Rule) libsbml.DowncastSBase(libsbmlPINVOKE.Rule_clone(swigCPtr), true);
	return ret;
}

  
/**
   * Returns the mathematical expression of this Rule in text-string form.
   *
   * The text string is produced by
   * @if java <c><a href='libsbml.html#formulaToString(org.sbml.libsbml.ASTNode)'>libsbml.formulaToString()</a></c>@else libsbmlcs.libsbml.formulaToString()@endif; please consult
   * the documentation for that function to find out more about the format
   * of the text-string formula.
   * 
   * @return the formula text string for this Rule.
   *
   * @note The attribute 'formula' is specific to SBML Level&nbsp;1; in
   * higher Levels of SBML, it has been replaced with a subelement named
   * 'math'.  However, libSBML provides a unified interface to the
   * underlying math expression and this method can be used for models
   * of all Levels of SBML.
   *
   * @see getMath()
   */ public
 string getFormula() {
    string ret = libsbmlPINVOKE.Rule_getFormula(swigCPtr);
    return ret;
  }

  
/**
   * Get the mathematical formula of this Rule as an ASTNode tree.
   *
   * @return an ASTNode, the value of the 'math' subelement of this Rule.
   *
   * @note The subelement 'math' is present in SBML Levels&nbsp;2
   * and&nbsp;3.  In SBML Level&nbsp;1, the equivalent construct is the
   * attribute named 'formula'.  LibSBML provides a unified interface to
   * the underlying math expression and this method can be used for models
   * of all Levels of SBML.
   *
   * @see getFormula()
   */ public
 ASTNode getMath() {
    IntPtr cPtr = libsbmlPINVOKE.Rule_getMath(swigCPtr);
    ASTNode ret = (cPtr == IntPtr.Zero) ? null : new ASTNode(cPtr, false);
    return ret;
  }

  
/**
   * Get the value of the 'variable' attribute of this Rule object.
   *
   * In SBML Level&nbsp;1, the different rule types each have a different
   * name for the attribute holding the reference to the object
   * constituting the left-hand side of the rule.  (E.g., for
   * SBML Level&nbsp;1's SpeciesConcentrationRule the attribute is 'species', for
   * CompartmentVolumeRule it is 'compartment', etc.)  In SBML
   * Levels&nbsp;2 and&nbsp;3, the only two types of Rule objects with a
   * left-hand side object reference are AssignmentRule and RateRule, and
   * both of them use the same name for attribute: 'variable'.  In order to
   * make it easier for application developers to work with all Levels of
   * SBML, libSBML uses a uniform name for all of such attributes, and it
   * is 'variable', regardless of whether Level&nbsp;1 rules or
   * Level&nbsp;2&ndash;3 rules are being used.
   * 
   * @return the identifier string stored as the 'variable' attribute value
   * in this Rule, or @c null if this object is an AlgebraicRule object.
   */ public
 string getVariable() {
    string ret = libsbmlPINVOKE.Rule_getVariable(swigCPtr);
    return ret;
  }

  
/**
   * Returns the units for the
   * mathematical formula of this Rule.
   * 
   * @return the identifier of the units for the expression of this Rule.
   *
   * @note The attribute 'units' exists on SBML Level&nbsp;1 ParameterRule
   * objects only.  It is not present in SBML Levels&nbsp;2 and&nbsp;3.
   */ public
 string getUnits() {
    string ret = libsbmlPINVOKE.Rule_getUnits(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * Rule's mathematical expression is set.
   * 
   * This method is equivalent to isSetMath().  This version is present for
   * easier compatibility with SBML Level&nbsp;1, in which mathematical
   * formulas were written in text-string form.
   * 
   * @return @c true if the mathematical formula for this Rule is
   * set, @c false otherwise.
   *
   * @note The attribute 'formula' is specific to SBML Level&nbsp;1; in
   * higher Levels of SBML, it has been replaced with a subelement named
   * 'math'.  However, libSBML provides a unified interface to the
   * underlying math expression and this method can be used for models
   * of all Levels of SBML.
   *
   * @see isSetMath()
   */ public
 bool isSetFormula() {
    bool ret = libsbmlPINVOKE.Rule_isSetFormula(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * Rule's mathematical expression is set.
   *
   * This method is equivalent to isSetFormula().
   * 
   * @return @c true if the formula (or equivalently the math) for this
   * Rule is set, @c false otherwise.
   *
   * @note The subelement 'math' is present in SBML Levels&nbsp;2
   * and&nbsp;3.  In SBML Level&nbsp;1, the equivalent construct is the
   * attribute named 'formula'.  LibSBML provides a unified interface to
   * the underlying math expression and this method can be used for models
   * of all Levels of SBML.
   *
   * @see isSetFormula()
   */ public
 bool isSetMath() {
    bool ret = libsbmlPINVOKE.Rule_isSetMath(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * Rule's 'variable' attribute is set.
   *
   * In SBML Level&nbsp;1, the different rule types each have a different
   * name for the attribute holding the reference to the object
   * constituting the left-hand side of the rule.  (E.g., for
   * SBML Level&nbsp;1's SpeciesConcentrationRule the attribute is 'species', for
   * CompartmentVolumeRule it is 'compartment', etc.)  In SBML
   * Levels&nbsp;2 and&nbsp;3, the only two types of Rule objects with a
   * left-hand side object reference are AssignmentRule and RateRule, and
   * both of them use the same name for attribute: 'variable'.  In order to
   * make it easier for application developers to work with all Levels of
   * SBML, libSBML uses a uniform name for all such attributes, and it is
   * 'variable', regardless of whether Level&nbsp;1 rules or
   * Level&nbsp;2&ndash;3 rules are being used.
   *
   * @return @c true if the 'variable' attribute value of this Rule is
   * set, @c false otherwise.
   */ public
 bool isSetVariable() {
    bool ret = libsbmlPINVOKE.Rule_isSetVariable(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true
   * if this Rule's 'units' attribute is set.
   *
   * @return @c true if the units for this Rule is set, @c false
   * otherwise
   *
   * @note The attribute 'units' exists on SBML Level&nbsp;1 ParameterRule
   * objects only.  It is not present in SBML Levels&nbsp;2 and&nbsp;3.
   */ public
 bool isSetUnits() {
    bool ret = libsbmlPINVOKE.Rule_isSetUnits(swigCPtr);
    return ret;
  }

  
/**
   * Sets the 'math' subelement of this Rule to an expression in
   * text-string form.
   *
   * This is equivalent to setMath(ASTNode math).  The provision of
   * using text-string formulas is retained for easier SBML Level&nbsp;1
   * compatibility.  The formula is converted to an ASTNode internally.
   *
   * @param formula a mathematical formula in text-string form.
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_OBJECT LIBSBML_INVALID_OBJECT @endlink
   *
   * @note The attribute 'formula' is specific to SBML Level&nbsp;1; in
   * higher Levels of SBML, it has been replaced with a subelement named
   * 'math'.  However, libSBML provides a unified interface to the
   * underlying math expression and this method can be used for models
   * of all Levels of SBML.
   *
   * @see setMath(ASTNode math)
   */ public
 int setFormula(string formula) {
    int ret = libsbmlPINVOKE.Rule_setFormula(swigCPtr, formula);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Sets the 'math' subelement of this Rule to a copy of the given
   * ASTNode.
   *
   * @param math the ASTNode structure of the mathematical formula.
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_OBJECT LIBSBML_INVALID_OBJECT @endlink
   *
   * @note The subelement 'math' is present in SBML Levels&nbsp;2
   * and&nbsp;3.  In SBML Level&nbsp;1, the equivalent construct is the
   * attribute named 'formula'.  LibSBML provides a unified interface to
   * the underlying math expression and this method can be used for models
   * of all Levels of SBML.
   *
   * @see setFormula(string formula)
   */ public
 int setMath(ASTNode math) {
    int ret = libsbmlPINVOKE.Rule_setMath(swigCPtr, ASTNode.getCPtr(math));
    return ret;
  }

  
/**
   * Sets the 'variable' attribute value of this Rule object.
   *
   * In SBML Level&nbsp;1, the different rule types each have a different
   * name for the attribute holding the reference to the object
   * constituting the left-hand side of the rule.  (E.g., for
   * SBML Level&nbsp;1's SpeciesConcentrationRule the attribute is 'species', for
   * CompartmentVolumeRule it is 'compartment', etc.)  In SBML
   * Levels&nbsp;2 and&nbsp;3, the only two types of Rule objects with a
   * left-hand side object reference are AssignmentRule and RateRule, and
   * both of them use the same name for attribute: 'variable'.  In order to
   * make it easier for application developers to work with all Levels of
   * SBML, libSBML uses a uniform name for all such attributes, and it is
   * 'variable', regardless of whether Level&nbsp;1 rules or
   * Level&nbsp;2&ndash;3 rules are being used.
   * 
   * @param sid the identifier of a Compartment, Species or Parameter
   * elsewhere in the enclosing Model object.
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE LIBSBML_UNEXPECTED_ATTRIBUTE @endlink
   */ public
 int setVariable(string sid) {
    int ret = libsbmlPINVOKE.Rule_setVariable(swigCPtr, sid);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Sets the units for this Rule.
   *
   * @param sname the identifier of the units
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE LIBSBML_UNEXPECTED_ATTRIBUTE @endlink
   *
   * @note The attribute 'units' exists on SBML Level&nbsp;1 ParameterRule
   * objects only.  It is not present in SBML Levels&nbsp;2 and&nbsp;3.
   */ public
 int setUnits(string sname) {
    int ret = libsbmlPINVOKE.Rule_setUnits(swigCPtr, sname);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Unsets the 'units' for this Rule.
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_UNEXPECTED_ATTRIBUTE LIBSBML_UNEXPECTED_ATTRIBUTE @endlink
   *
   * @note The attribute 'units' exists on SBML Level&nbsp;1 ParameterRule
   * objects only.  It is not present in SBML Levels&nbsp;2 and&nbsp;3.
   */ public
 int unsetUnits() {
    int ret = libsbmlPINVOKE.Rule_unsetUnits(swigCPtr);
    return ret;
  }

  
/**
   * Calculates and returns a UnitDefinition that expresses the units of
   * measurement assumed for the 'math' expression of this Rule.
   *
   * The units are calculated based on the mathematical expression in the
   * Rule and the model quantities referenced by <c>&lt;ci&gt;</c>
   * elements used within that expression.  The getDerivedUnitDefinition()
   * method returns the calculated units.
   *
   * Note that the functionality that facilitates unit analysis depends 
   * on the model as a whole.  Thus, in cases where the object has not 
   * been added to a model or the model itself is incomplete,
   * unit analysis is not possible and this method will return @c null.
   *
   * @warning Note that it is possible the 'math' expression in the Rule
   * contains pure numbers or parameters with undeclared units.  In those
   * cases, it is not possible to calculate the units of the overall
   * expression without making assumptions.  LibSBML does not make
   * assumptions about the units, and getDerivedUnitDefinition() only
   * returns the units as far as it is able to determine them.  For
   * example, in an expression <em>X + Y</em>, if <em>X</em> has
   * unambiguously-defined units and <em>Y</em> does not, it will return
   * the units of <em>X</em>.  <strong>It is important that callers also
   * invoke the method</strong>
   * @if java Rule::containsUndeclaredUnits()@else containsUndeclaredUnits()@endif@~
   * <strong>to determine whether this situation holds</strong>.  Callers may
   * wish to take suitable actions in those scenarios.
   * 
   * @return a UnitDefinition that expresses the units of the math 
   * expression of this Rule, or @c null if one cannot be constructed.
   *
   * @see containsUndeclaredUnits()
   */ public
 UnitDefinition getDerivedUnitDefinition() {
    IntPtr cPtr = libsbmlPINVOKE.Rule_getDerivedUnitDefinition__SWIG_0(swigCPtr);
    UnitDefinition ret = (cPtr == IntPtr.Zero) ? null : new UnitDefinition(cPtr, false);
    return ret;
  }

  
/**
   * Predicate returning @c true if 
   * the math expression of this Rule contains
   * parameters/numbers with undeclared units.
   * 
   * @return @c true if the math expression of this Rule
   * includes parameters/numbers 
   * with undeclared units, @c false otherwise.
   *
   * @note A return value of @c true indicates that the UnitDefinition
   * returned by getDerivedUnitDefinition() may not accurately represent
   * the units of the expression.
   *
   * @see getDerivedUnitDefinition()
   */ public
 bool containsUndeclaredUnits() {
    bool ret = libsbmlPINVOKE.Rule_containsUndeclaredUnits__SWIG_0(swigCPtr);
    return ret;
  }

  
/**
   * Get the type of rule this is.
   * 
   * @return the rule type (a value drawn from the enumeration <a
   * class='el' href='#RuleType_t'>RuleType_t</a>) of this Rule.  The value
   * will be either @link libsbmlcs.libsbml.RULE_TYPE_RATE RULE_TYPE_RATE@endlink
   * or @link libsbmlcs.libsbml.RULE_TYPE_SCALAR RULE_TYPE_SCALAR@endlink.
   *
   * @note The attribute 'type' on Rule objects is present only in SBML
   * Level&nbsp;1.  In SBML Level&nbsp;2 and later, the type has been
   * replaced by subclassing the Rule object.
   */ public
 int getType() {
    int ret = libsbmlPINVOKE.Rule_getType(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * Rule is an AlgebraicRule.
   * 
   * @return @c true if this Rule is an AlgebraicRule, @c false otherwise.
   */ public
 bool isAlgebraic() {
    bool ret = libsbmlPINVOKE.Rule_isAlgebraic(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this
   * Rule is an AssignmentRule.
   * 
   * @return @c true if this Rule is an AssignmentRule, @c false otherwise.
   */ public
 bool isAssignment() {
    bool ret = libsbmlPINVOKE.Rule_isAssignment(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this Rule is an CompartmentVolumeRule
   * or equivalent.
   *
   * This libSBML method works for SBML Level&nbsp;1 models (where there is
   * such a thing as an explicit CompartmentVolumeRule), as well as other Levels of
   * SBML.  For Levels above Level&nbsp;1, this method checks the symbol
   * being affected by the rule, and returns @c true if the symbol is the
   * identifier of a Compartment object defined in the model.
   *
   * @return @c true if this Rule is a CompartmentVolumeRule, @c false
   * otherwise.
   */ public
 bool isCompartmentVolume() {
    bool ret = libsbmlPINVOKE.Rule_isCompartmentVolume(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this Rule is an ParameterRule or
   * equivalent.
   *
   * This libSBML method works for SBML Level&nbsp;1 models (where there is
   * such a thing as an explicit ParameterRule), as well as other Levels of
   * SBML.  For Levels above Level&nbsp;1, this method checks the symbol
   * being affected by the rule, and returns @c true if the symbol is the
   * identifier of a Parameter object defined in the model.
   *
   * @return @c true if this Rule is a ParameterRule, @c false
   * otherwise.
   */ public
 bool isParameter() {
    bool ret = libsbmlPINVOKE.Rule_isParameter(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this Rule
   * is a RateRule (SBML Levels&nbsp;2&ndash;3) or has a 'type' attribute
   * value of @c 'rate' (SBML Level&nbsp;1).
   *
   * @return @c true if this Rule is a RateRule (Level&nbsp;2) or has
   * type 'rate' (Level&nbsp;1), @c false otherwise.
   */ public
 bool isRate() {
    bool ret = libsbmlPINVOKE.Rule_isRate(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this Rule
   * is an AssignmentRule (SBML Levels&nbsp;2&ndash;3) or has a 'type'
   * attribute value of @c 'scalar' (SBML Level&nbsp;1).
   *
   * @return @c true if this Rule is an AssignmentRule (Level&nbsp;2) or has
   * type 'scalar' (Level&nbsp;1), @c false otherwise.
   */ public
 bool isScalar() {
    bool ret = libsbmlPINVOKE.Rule_isScalar(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this Rule is a
   * SpeciesConcentrationRule or equivalent.
   *
   * This libSBML method works for SBML Level&nbsp;1 models (where there is
   * such a thing as an explicit SpeciesConcentrationRule), as well as
   * other Levels of SBML.  For Levels above Level&nbsp;1, this method
   * checks the symbol being affected by the rule, and returns @c true if
   * the symbol is the identifier of a Species object defined in the model.
   *
   * @return @c true if this Rule is a SpeciesConcentrationRule, @c false
   * otherwise.
   */ public
 bool isSpeciesConcentration() {
    bool ret = libsbmlPINVOKE.Rule_isSpeciesConcentration(swigCPtr);
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
   * @return the SBML type code for this object, or @link
   * libsbmlcs.libsbml.SBML_UNKNOWN SBML_UNKNOWN@endlink (default).
   *
   * @see getElementName()
   */ public new
 int getTypeCode() {
    int ret = libsbmlPINVOKE.Rule_getTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the SBML Level&nbsp;1 type code for this Rule object.
   *
   * This method only applies to SBML Level&nbsp;1 model objects.  If this
   * is not an SBML Level&nbsp;1 rule object, this method will return @link
   * libsbmlcs.libsbml.SBML_UNKNOWN SBML_UNKNOWN@endlink.
   * 
   * @return the SBML Level&nbsp;1 type code for this Rule (namely, @link
   * libsbmlcs.libsbml.SBML_COMPARTMENT_VOLUME_RULE
   * SBML_COMPARTMENT_VOLUME_RULE@endlink, @link
   * libsbmlcs.libsbml.SBML_PARAMETER_RULE SBML_PARAMETER_RULE@endlink, @link
   * libsbmlcs.libsbml.SBML_SPECIES_CONCENTRATION_RULE
   * SBML_SPECIES_CONCENTRATION_RULE@endlink, or @link
   * libsbmlcs.libsbml.SBML_UNKNOWN SBML_UNKNOWN@endlink).
   */ public
 int getL1TypeCode() {
    int ret = libsbmlPINVOKE.Rule_getL1TypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the XML element name of this object
   *
   * The returned value can be any of a number of different strings,
   * depending on the SBML Level in use and the kind of Rule object this
   * is.  The rules as of libSBML version @htmlinclude libsbml-version.html
   * are the following:
   * <ul>
   * <li> (Level&nbsp;2 and&nbsp;3) RateRule: returns @c 'rateRule'
   * <li> (Level&nbsp;2 and&nbsp;3) AssignmentRule: returns @c 'assignmentRule' 
   * <li> (Level&nbsp;2 and&nbsp;3) AlgebraicRule: returns @c 'algebraicRule'
   * <li> (Level&nbsp;1 Version&nbsp;1) SpecieConcentrationRule: returns @c 'specieConcentrationRule'
   * <li> (Level&nbsp;1 Version&nbsp;2) SpeciesConcentrationRule: returns @c 'speciesConcentrationRule'
   * <li> (Level&nbsp;1) CompartmentVolumeRule: returns @c 'compartmentVolumeRule'
   * <li> (Level&nbsp;1) ParameterRule: returns @c 'parameterRule'
   * <li> Unknown rule type: returns @c 'unknownRule'
   * </ul>
   *
   * Beware that the last (@c 'unknownRule') is not a valid SBML element
   * name.
   * 
   * @return the name of this element
   */ public new
 string getElementName() {
    string ret = libsbmlPINVOKE.Rule_getElementName(swigCPtr);
    return ret;
  }

  
/**
   * Sets the SBML Level&nbsp;1 type code for this Rule.
   *
   * @param type the SBML Level&nbsp;1 type code for this Rule. The
   * allowable values are @link libsbmlcs.libsbml.SBML_COMPARTMENT_VOLUME_RULE
   * SBML_COMPARTMENT_VOLUME_RULE@endlink, @link
   * libsbmlcs.libsbml.SBML_PARAMETER_RULE SBML_PARAMETER_RULE@endlink, and
   * @link libsbmlcs.libsbml.SBML_SPECIES_CONCENTRATION_RULE
   * SBML_SPECIES_CONCENTRATION_RULE@endlink.
   *
   * @return integer value indicating success/failure of the
   * function.  The possible values returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE@endlink
   * if given @p type value is not one of the above.
   */ public
 int setL1TypeCode(int type) {
    int ret = libsbmlPINVOKE.Rule_setL1TypeCode(swigCPtr, type);
    return ret;
  }

  
/**
   * Predicate returning @c true if all the
   * required elements for this Rule object have been set.
   *
   * The only required element for a Rule object is the 'math' subelement.
   *
   * @return a bool value indicating whether all the required
   * elements for this object have been defined.
   */ public new
 bool hasRequiredElements() {
    bool ret = libsbmlPINVOKE.Rule_hasRequiredElements(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if all the
   * required attributes for this Rule object have been set.
   *
   * The required attributes for a Rule object depend on the type of Rule
   * it is.  For AssignmentRule and RateRule objects (and SBML
   * Level&nbsp1's SpeciesConcentrationRule, CompartmentVolumeRule, and
   * ParameterRule objects), the required attribute is 'variable'; for
   * AlgebraicRule objects, there is no required attribute.
   *
   * @return a bool value indicating whether all the required
   * elements for this object have been defined.
   */ public new
 bool hasRequiredAttributes() {
    bool ret = libsbmlPINVOKE.Rule_hasRequiredAttributes(swigCPtr);
    return ret;
  }

  
/**
   * Renames all the SIdRef attributes on this element, including any found in MathML
   */ public
 void renameSIdRefs(string oldid, string newid) {
    libsbmlPINVOKE.Rule_renameSIdRefs(swigCPtr, oldid, newid);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Renames all the UnitSIdRef attributes on this element
   */ public
 void renameUnitSIdRefs(string oldid, string newid) {
    libsbmlPINVOKE.Rule_renameUnitSIdRefs(swigCPtr, oldid, newid);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Renames all the UnitSIdRef attributes on this element
   */ public new
 string getId() {
    string ret = libsbmlPINVOKE.Rule_getId(swigCPtr);
    return ret;
  }

  
/**
   * Replace all nodes with the name 'id' from the child 'math' object with the provided function. 
   *
   */ /* libsbml-internal */ public
 void replaceSIDWithFunction(string id, ASTNode function) {
    libsbmlPINVOKE.Rule_replaceSIDWithFunction(swigCPtr, id, ASTNode.getCPtr(function));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * If this rule assigns a value or a change to the 'id' element, replace the 'math' object with the function (existing/function). 
   */ /* libsbml-internal */ public
 void divideAssignmentsToSIdByFunction(string id, ASTNode function) {
    libsbmlPINVOKE.Rule_divideAssignmentsToSIdByFunction(swigCPtr, id, ASTNode.getCPtr(function));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * If this assignment assigns a value to the 'id' element, replace the 'math' object with the function (existing*function). 
   */ /* libsbml-internal */ public
 void multiplyAssignmentsToSIdByFunction(string id, ASTNode function) {
    libsbmlPINVOKE.Rule_multiplyAssignmentsToSIdByFunction(swigCPtr, id, ASTNode.getCPtr(function));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
