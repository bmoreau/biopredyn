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
 * SBML converter for reordering rules and assignments in a model.
 * <p>
 * <p style='color: #777; font-style: italic'>
This class of objects is defined by libSBML only and has no direct
equivalent in terms of SBML components.  It is a class used in
the implementation of extra functionality provided by libSBML.
</p>

 * <p>
 * This converter reorders assignments in a model.  Specifically, it sorts
 * the list of assignment rules (i.e., the {@link AssignmentRule} objects contained
 * in the ListOfAssignmentRules within the {@link Model} object) and the initial
 * assignments (i.e., the {@link InitialAssignment} objects contained in the
 * {@link ListOfInitialAssignments}) such that, within each set, assignments that
 * depend on prior values are placed after the values are set.  For
 * example, if there is an assignment rule stating <i>a = b + 1</i>, and
 * another rule stating <i>b = 3</i>, the list of rules is sorted and the
 * rules are arranged so that the rule for <i>b = 3</i> appears <em>before</em>
 * the rule for <i>a = b + 1</i>.  Similarly, if dependencies of this
 * sort exist in the list of initial assignments in the model, the initial
 * assignments are sorted as well.
 * <p>
 * Beginning with SBML Level 2, assignment rules have no ordering
 * required&mdash;the order in which the rules appear in an SBML file has
 * no significance.  Software tools, however, may need to reorder
 * assignments for purposes of evaluating them.  For example, for
 * simulators that use time integration methods, it would be a good idea to
 * reorder assignment rules such as the following,
 * <p>
 * <i>b = a + 10 seconds</i><br>
 * <i>a = time</i>
 * <p>
 * so that the evaluation of the rules is independent of integrator
 * step sizes. (This is due to the fact that, in this case, the order in
 * which the rules are evaluated changes the result.)  This converter
 * can be used to reorder the SBML objects regardless of whether the
 * input file contained them in the desired order.  Here is a code
 * fragment to illustrate how to do that:
 * <div class='fragment'><pre>
{@link ConversionProperties} props;
props.addOption('sortRules', true, 'sort rules');

{@link SBMLConverter} converter;
converter.setProperties(&props);
converter.setDocument(&doc);
converter.convert(); 
</pre></div>
 * <p>
 * @note The two sets of assignments (list of assignment rules on the one
 * hand, and list of initial assignments on the other hand) are handled 
 * <em>independently</em>.  In an SBML model, these entities are treated differently
 * and no amount of sorting can deal with inter-dependencies between
 * assignments of the two kinds.
 * <p>
 * @see SBMLFunctionDefinitionConverter
 * @see SBMLInitialAssignmentConverter
 * @see SBMLLevelVersionConverter
 * @see SBMLStripPackageConverter
 * @see SBMLUnitsConverter
 */

public class SBMLRuleConverter extends SBMLConverter {
   private long swigCPtr;

   protected SBMLRuleConverter(long cPtr, boolean cMemoryOwn)
   {
     super(libsbmlJNI.SBMLRuleConverter_SWIGUpcast(cPtr), cMemoryOwn);
     swigCPtr = cPtr;
   }

   protected static long getCPtr(SBMLRuleConverter obj)
   {
     return (obj == null) ? 0 : obj.swigCPtr;
   }

   protected static long getCPtrAndDisown (SBMLRuleConverter obj)
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
        libsbmlJNI.delete_SBMLRuleConverter(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public static void init() {
    libsbmlJNI.SBMLRuleConverter_init();
  }

  
/**
   * Creates a new {@link SBMLLevelVersionConverter} object.
   */ public
 SBMLRuleConverter() {
    this(libsbmlJNI.new_SBMLRuleConverter__SWIG_0(), true);
  }

  
/**
   * Copy constructor; creates a copy of an {@link SBMLLevelVersionConverter}
   * object.
   * <p>
   * @param obj the {@link SBMLLevelVersionConverter} object to copy.
   */ public
 SBMLRuleConverter(SBMLRuleConverter obj) {
    this(libsbmlJNI.new_SBMLRuleConverter__SWIG_1(SBMLRuleConverter.getCPtr(obj), obj), true);
  }

  
/**
   * Creates and returns a deep copy of this {@link SBMLLevelVersionConverter}
   * object.
   * <p>
   * @return a (deep) copy of this converter.
   */ public
 SBMLConverter cloneObject() {
    long cPtr = libsbmlJNI.SBMLRuleConverter_cloneObject(swigCPtr, this);
    return (cPtr == 0) ? null : new SBMLConverter(cPtr, true);
  }

  
/**
   * Returns <code>true</code> if this converter object's properties match the given
   * properties.
   * <p>
   * A typical use of this method involves creating a {@link ConversionProperties}
   * object, setting the options desired, and then calling this method on
   * an {@link SBMLLevelVersionConverter} object to find out if the object's
   * property values match the given ones.  This method is also used by
   * {@link SBMLConverterRegistry#getConverterFor(ConversionProperties props)}
   * to search across all registered converters for one matching particular
   * properties.
   * <p>
   * @param props the properties to match.
   * <p>
   * @return <code>true</code> if this converter's properties match, <code>false</code>
   * otherwise.
   */ public
 boolean matchesProperties(ConversionProperties props) {
    return libsbmlJNI.SBMLRuleConverter_matchesProperties(swigCPtr, this, ConversionProperties.getCPtr(props), props);
  }

  
/** 
   * Perform the conversion.
   * <p>
   * This method causes the converter to do the actual conversion work,
   * that is, to convert the {@link SBMLDocument} object set by
   * {@link SBMLConverter#setDocument(SBMLDocument doc)} and
   * with the configuration options set by
   * {@link SBMLConverter#setProperties(ConversionProperties props)}.
   * <p>
   * @return  integer value indicating the success/failure of the operation.
   *  The possible values are:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * <li> {@link  libsbmlConstants#LIBSBML_INVALID_OBJECT LIBSBML_INVALID_OBJECT }
   * <li> {@link  libsbmlConstants#LIBSBML_CONV_INVALID_SRC_DOCUMENT LIBSBML_CONV_INVALID_SRC_DOCUMENT }
   * </ul>
   */ public
 int convert() {
    return libsbmlJNI.SBMLRuleConverter_convert(swigCPtr, this);
  }

  
/**
   * Returns the default properties of this converter.
   * <p>
   * A given converter exposes one or more properties that can be adjusted
   * in order to influence the behavior of the converter.  This method
   * returns the <em>default</em> property settings for this converter.  It is
   * meant to be called in order to discover all the settings for the
   * converter object.
   * <p>
   * @return the {@link ConversionProperties} object describing the default properties
   * for this converter.
   */ public
 ConversionProperties getDefaultProperties() {
    return new ConversionProperties(libsbmlJNI.SBMLRuleConverter_getDefaultProperties(swigCPtr, this), true);
  }

}
