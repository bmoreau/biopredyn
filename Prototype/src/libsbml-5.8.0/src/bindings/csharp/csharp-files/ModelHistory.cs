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
 * Representation of MIRIAM-compliant model history data.
 *
 * @htmlinclude not-sbml-warning.html
 *
 * The SBML specification beginning with Level&nbsp;2 Version&nbsp;2
 * defines a standard approach to recording optional model history and
 * model creator information in a form that complies with MIRIAM ('Minimum
 * Information Requested in the Annotation of biochemical Models',
 * <i>Nature Biotechnology</i>, vol. 23, no. 12, Dec. 2005).  LibSBML
 * provides the ModelHistory class as a convenient high-level interface
 * for working with model history data.
 *
 * Model histories in SBML consist of one or more <em>model creators</em>,
 * a single date of @em creation, and one or more @em modification dates.
 * The overall XML form of this data takes the following form:
 * 
 <pre class='fragment'>
 &lt;dc:creator&gt;
   &lt;rdf:Bag&gt;
     &lt;rdf:li rdf:parseType='Resource'&gt;
       <span style='background-color: #d0eed0'>+++</span>
       &lt;vCard:N rdf:parseType='Resource'&gt;
         &lt;vCard:Family&gt;<span style='background-color: #bbb'>family name</span>&lt;/vCard:Family&gt;
         &lt;vCard:Given&gt;<span style='background-color: #bbb'>given name</span>&lt;/vCard:Given&gt;
       &lt;/vCard:N&gt;
       <span style='background-color: #d0eed0'>+++</span>
       <span style='border-bottom: 2px dotted #888'>&lt;vCard:EMAIL&gt;<span style='background-color: #bbb'>email address</span>&lt;/vCard:EMAIL&gt;</span>
       <span style='background-color: #d0eed0'>+++</span>
       <span style='border-bottom: 2px dotted #888'>&lt;vCard:ORG rdf:parseType='Resource'&gt;</span>
        <span style='border-bottom: 2px dotted #888'>&lt;vCard:Orgname&gt;<span style='background-color: #bbb'>organization name</span>&lt;/vCard:Orgname&gt;</span>
       <span style='border-bottom: 2px dotted #888'>&lt;/vCard:ORG&gt;</span>
       <span style='background-color: #d0eed0'>+++</span>
     &lt;/rdf:li&gt;
     <span style='background-color: #edd'>...</span>
   &lt;/rdf:Bag&gt;
 &lt;/dc:creator&gt;
 &lt;dcterms:created rdf:parseType='Resource'&gt;
   &lt;dcterms:W3CDTF&gt;<span style='background-color: #bbb'>creation date</span>&lt;/dcterms:W3CDTF&gt;
 &lt;/dcterms:created&gt;
 &lt;dcterms:modified rdf:parseType='Resource'&gt;
   &lt;dcterms:W3CDTF&gt;<span style='background-color: #bbb'>modification date</span>&lt;/dcterms:W3CDTF&gt;
 &lt;/dcterms:modified&gt;
 <span style='background-color: #edd'>...</span>
 </pre>
 *
 * In the template above, the <span style='border-bottom: 2px dotted #888'>underlined</span>
 * portions are optional, the symbol
 * <span class='code' style='background-color: #d0eed0'>+++</span> is a placeholder
 * for either no content or valid XML content that is not defined by
 * the annotation scheme, and the ellipses
 * <span class='code' style='background-color: #edd'>...</span>
 * are placeholders for zero or more elements of the same form as the
 * immediately preceding element.  The various placeholders for content, namely
 * <span class='code' style='background-color: #bbb'>family name</span>,
 * <span class='code' style='background-color: #bbb'>given name</span>,
 * <span class='code' style='background-color: #bbb'>email address</span>,
 * <span class='code' style='background-color: #bbb'>organization</span>,
 * <span class='code' style='background-color: #bbb'>creation date</span>, and
 * <span class='code' style='background-color: #bbb'>modification date</span>
 * are data that can be filled in using the various methods on
 * the ModelHistory class described below.
 *
 *
 * <!-- leave this next break as-is to work around some doxygen bug -->
 */

public class ModelHistory : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal ModelHistory(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(ModelHistory obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (ModelHistory obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~ModelHistory() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_ModelHistory(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static bool operator==(ModelHistory lhs, ModelHistory rhs)
  {
    if((Object)lhs == (Object)rhs)
    {
      return true;
    }

    if( ((Object)lhs == null) || ((Object)rhs == null) )
    {
      return false;
    }

    return (getCPtr(lhs).Handle.ToString() == getCPtr(rhs).Handle.ToString());
  }

  public static bool operator!=(ModelHistory lhs, ModelHistory rhs)
  {
    return !(lhs == rhs);
  }

  public override bool Equals(Object sb)
  {
    if ( ! (sb is ModelHistory) )
    {
      return false;
    }

    return this == (ModelHistory)sb;
  }

  public override int GetHashCode()
  {
    return swigCPtr.Handle.ToInt32();
  }

  
/**
   * Creates a new ModelHistory object.
   */ public
 ModelHistory() : this(libsbmlPINVOKE.new_ModelHistory__SWIG_0(), true) {
  }

  
/**
   * Copy constructor; creates a copy of this ModelHistory object.
   *
   * @param orig the object to copy.
   * 
   * @throws @if python ValueError @else SBMLConstructorException @endif@~
   * Thrown if the argument @p orig is @c null.
   */ public
 ModelHistory(ModelHistory orig) : this(libsbmlPINVOKE.new_ModelHistory__SWIG_1(ModelHistory.getCPtr(orig)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a copy of this ModelHistory object
   *
   * @return a (deep) copy of this ModelHistory object.
   */ public
 ModelHistory clone() {
    IntPtr cPtr = libsbmlPINVOKE.ModelHistory_clone(swigCPtr);
    ModelHistory ret = (cPtr == IntPtr.Zero) ? null : new ModelHistory(cPtr, true);
    return ret;
  }

  
/**
   * Returns the 'creation date' portion of this ModelHistory object.
   *
   * @return a Date object representing the creation date stored in
   * this ModelHistory object.
   */ public
 Date getCreatedDate() {
    IntPtr cPtr = libsbmlPINVOKE.ModelHistory_getCreatedDate(swigCPtr);
    Date ret = (cPtr == IntPtr.Zero) ? null : new Date(cPtr, false);
    return ret;
  }

  
/**
   * Returns the 'modified date' portion of this ModelHistory object.
   * 
   * Note that in the MIRIAM format for annotations, there can be multiple
   * modification dates.  The libSBML ModelHistory class supports this by
   * storing a list of 'modified date' values.  If this ModelHistory object
   * contains more than one 'modified date' value in the list, this method
   * will return the first one in the list.
   *
   * @return a Date object representing the date of modification
   * stored in this ModelHistory object.
   */ public
 Date getModifiedDate() {
    IntPtr cPtr = libsbmlPINVOKE.ModelHistory_getModifiedDate__SWIG_0(swigCPtr);
    Date ret = (cPtr == IntPtr.Zero) ? null : new Date(cPtr, false);
    return ret;
  }

  
/**
   * Predicate returning @c true or @c false depending on whether this
   * ModelHistory's 'creation date' is set.
   *
   * @return @c true if the creation date value of this ModelHistory is
   * set, @c false otherwise.
   */ public
 bool isSetCreatedDate() {
    bool ret = libsbmlPINVOKE.ModelHistory_isSetCreatedDate(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true or @c false depending on whether this
   * ModelHistory's 'modified date' is set.
   *
   * @return @c true if the modification date value of this ModelHistory
   * object is set, @c false otherwise.
   */ public
 bool isSetModifiedDate() {
    bool ret = libsbmlPINVOKE.ModelHistory_isSetModifiedDate(swigCPtr);
    return ret;
  }

  
/**
   * Sets the creation date of this ModelHistory object.
   *  
   * @param date a Date object representing the date to which the 'created
   * date' portion of this ModelHistory should be set.
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif@~ The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_OBJECT LIBSBML_INVALID_OBJECT @endlink
   */ public
 int setCreatedDate(Date date) {
    int ret = libsbmlPINVOKE.ModelHistory_setCreatedDate(swigCPtr, Date.getCPtr(date));
    return ret;
  }

  
/**
   * Sets the modification date of this ModelHistory object.
   *  
   * @param date a Date object representing the date to which the 'modified
   * date' portion of this ModelHistory should be set.
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif@~ The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_OBJECT LIBSBML_INVALID_OBJECT @endlink
   */ public
 int setModifiedDate(Date date) {
    int ret = libsbmlPINVOKE.ModelHistory_setModifiedDate(swigCPtr, Date.getCPtr(date));
    return ret;
  }

  
/**
   * Adds a copy of a Date object to the list of 'modified date' values
   * stored in this ModelHistory object.
   *
   * In the MIRIAM format for annotations, there can be multiple
   * modification dates.  The libSBML ModelHistory class supports this by
   * storing a list of 'modified date' values.
   *  
   * @param date a Date object representing the 'modified date' that should
   * be added to this ModelHistory object.
   * 
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif@~ The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_OBJECT LIBSBML_INVALID_OBJECT @endlink
   */ public
 int addModifiedDate(Date date) {
    int ret = libsbmlPINVOKE.ModelHistory_addModifiedDate(swigCPtr, Date.getCPtr(date));
    return ret;
  }

  
/**
   * Returns the list of 'modified date' values (as Date objects) stored in
   * this ModelHistory object.
   * 
   * In the MIRIAM format for annotations, there can be multiple
   * modification dates.  The libSBML ModelHistory class supports this by
   * storing a list of 'modified date' values.
   * 
   * @return the list of modification dates for this ModelHistory object.
   */ public
  DateList  getListModifiedDates() { 
  IntPtr cPtr = libsbmlPINVOKE.ModelHistory_getListModifiedDates(swigCPtr);
  return (cPtr == IntPtr.Zero) ? null : new DateList(cPtr, true);
}

  
/**
   * Get the nth Date object in the list of 'modified date' values stored
   * in this ModelHistory object.
   * 
   * In the MIRIAM format for annotations, there can be multiple
   * modification dates.  The libSBML ModelHistory class supports this by
   * storing a list of 'modified date' values.
   * 
   * @return the nth Date in the list of ModifiedDates of this
   * ModelHistory.
   */ public
 Date getModifiedDate(long n) {
    IntPtr cPtr = libsbmlPINVOKE.ModelHistory_getModifiedDate__SWIG_1(swigCPtr, n);
    Date ret = (cPtr == IntPtr.Zero) ? null : new Date(cPtr, false);
    return ret;
  }

  
/**
   * Get the number of Date objects in this ModelHistory object's list of
   * 'modified dates'.
   * 
   * In the MIRIAM format for annotations, there can be multiple
   * modification dates.  The libSBML ModelHistory class supports this by
   * storing a list of 'modified date' values.
   * 
   * @return the number of ModifiedDates in this ModelHistory.
   */ public
 long getNumModifiedDates() { return (long)libsbmlPINVOKE.ModelHistory_getNumModifiedDates(swigCPtr); }

  
/**
   * Adds a copy of a ModelCreator object to the list of 'model creator'
   * values stored in this ModelHistory object.
   *
   * In the MIRIAM format for annotations, there can be multiple model
   * creators.  The libSBML ModelHistory class supports this by storing a
   * list of 'model creator' values.
   * 
   * @param mc the ModelCreator to add
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif@~ The possible values
   * returned by this function are:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_INVALID_OBJECT LIBSBML_INVALID_OBJECT @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   */ public
 int addCreator(ModelCreator mc) {
    int ret = libsbmlPINVOKE.ModelHistory_addCreator(swigCPtr, ModelCreator.getCPtr(mc));
    return ret;
  }

  
/**
   * Returns the list of ModelCreator objects stored in this ModelHistory
   * object.
   *
   * In the MIRIAM format for annotations, there can be multiple model
   * creators.  The libSBML ModelHistory class supports this by storing a
   * list of 'model creator' values.
   * 
   * @return the list of ModelCreator objects.
   */ public
  ModelCreatorList  getListCreators() { 
  IntPtr cPtr = libsbmlPINVOKE.ModelHistory_getListCreators(swigCPtr);
  return (cPtr == IntPtr.Zero) ? null : new ModelCreatorList(cPtr, true);
}

  
/**
   * Get the nth ModelCreator object stored in this ModelHistory object.
   *
   * In the MIRIAM format for annotations, there can be multiple model
   * creators.  The libSBML ModelHistory class supports this by storing a
   * list of 'model creator' values.
   * 
   * @return the nth ModelCreator object.
   */ public
 ModelCreator getCreator(long n) {
    IntPtr cPtr = libsbmlPINVOKE.ModelHistory_getCreator(swigCPtr, n);
    ModelCreator ret = (cPtr == IntPtr.Zero) ? null : new ModelCreator(cPtr, false);
    return ret;
  }

  
/**
   * Get the number of ModelCreator objects stored in this ModelHistory
   * object.
   *
   * In the MIRIAM format for annotations, there can be multiple model
   * creators.  The libSBML ModelHistory class supports this by storing a
   * list of 'model creator' values.
   * 
   * @return the number of ModelCreators objects.
   */ public
 long getNumCreators() { return (long)libsbmlPINVOKE.ModelHistory_getNumCreators(swigCPtr); }

  
/**
   * Predicate returning @c true if all the required elements for this
   * ModelHistory object have been set.
   *
   * The required elements for a ModelHistory object are 'created
   * name', 'modified date', and at least one 'model creator'.
   *
   * @return a bool value indicating whether all the required
   * elements for this object have been defined.
   */ public
 bool hasRequiredAttributes() {
    bool ret = libsbmlPINVOKE.ModelHistory_hasRequiredAttributes(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if all the required elements for this
   * ModelHistory object have been set.
   *
   * The required elements for a ModelHistory object are 'created
   * name', 'modified date', and at least one 'model creator'.
   *
   * @return a bool value indicating whether all the required
   * elements for this object have been defined.
   */ /* libsbml-internal */ public
 bool hasBeenModified() {
    bool ret = libsbmlPINVOKE.ModelHistory_hasBeenModified(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if all the required elements for this
   * ModelHistory object have been set.
   *
   * The required elements for a ModelHistory object are 'created
   * name', 'modified date', and at least one 'model creator'.
   *
   * @return a bool value indicating whether all the required
   * elements for this object have been defined.
   */ /* libsbml-internal */ public
 void resetModifiedFlags() {
    libsbmlPINVOKE.ModelHistory_resetModifiedFlags(swigCPtr);
  }

}

}
