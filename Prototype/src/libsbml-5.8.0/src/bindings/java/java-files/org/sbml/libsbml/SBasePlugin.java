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
 * Representation of a plug-in object of SBML's package extension.
 * <p>
 * Additional attributes and/or elements of a package extension which are directly 
 * contained by some pre-defined element are contained/accessed by <a href='#{@link SBasePlugin}'> 
 * {@link SBasePlugin} </a> class which is extended by package developers for each extension point.
 * The extension point, which represents an element to be extended, is identified by a 
 * combination of a Package name and a typecode of the element, and is represented by
 * {@link SBaseExtensionPoint} class.
 * </p>
 * <p>
 * <p>
 * For example, the layout extension defines <em>&lt;listOfLayouts&gt;</em> element which is 
 * directly contained in <em>&lt;model&gt;</em> element of the core package. 
 * In the layout package (provided as one of example packages in libSBML-5), the additional 
 * element for the model element is implemented as ListOfLayouts class (an {@link SBase} derived class) and 
 * the object is contained/accessed by a LayoutModelPlugin class (an {@link SBasePlugin} derived class). 
 * </p>
 * <p>
 * <p>
 * {@link SBasePlugin} class defines basic virtual functions for reading/writing/checking 
 * additional attributes and/or top-level elements which should or must be overridden by 
 * subclasses like {@link SBase} class and its derived classes.
 * </p>
 * <p>
 * <p>
 *  Package developers must implement an {@link SBasePlugin} exntended class for 
 *  each element to be extended (e.g. {@link SBMLDocument}, {@link Model}, ...) in which additional 
 *  attributes and/or top-level elements of the package extension are directly contained.
 *</p>
 * <p>
 *  To implement reading/writing functions for attributes and/or top-level 
 *  elements of the SBsaePlugin extended class, package developers should or must
 *  override the corresponding virtual functions below provided in the {@link SBasePlugin} class:
 * <p>
 *   <ul>
 *     <li> <p>reading elements : </p>
 *       <ol>
 *         <li> <code>virtual {@link SBase} createObject (XMLInputStream& stream) </code>
 *         <p>This function must be overridden if one or more additional elements are defined.</p>
 *         </li>
 *         <li> <code>virtual bool readOtherXML (SBase parentObject, XMLInputStream& stream)</code>
 *         <p>This function should be overridden if elements of annotation, notes, MathML, etc. need 
 *            to be directly parsed from the given XMLInputStream object instead of the
 *            {@link SBase#readAnnotation(XMLInputStream& stream)} 
 *            and/or {@link SBase#readNotes(XMLInputStream& stream)} functions.
 *         </p> 
 *         </li>
 *       </ol>
 *     </li>
 *     <li> <p>reading attributes (must be overridden if additional attributes are defined) :</p>
 *       <ol>
 *         <li><code>virtual void addExpectedAttributes(ExpectedAttributes& attributes) </code></li>
 *         <li><code>virtual void readAttributes (XMLAttributes attributes, const ExpectedAttributes& expectedAttributes)</code></li>
 *       </ol>
 *     </li>
 *     <li> <p>writing elements (must be overridden if additional elements are defined) :</p>
 *       <ol>
 *         <li><code>virtual void writeElements (XMLOutputStream& stream) const </code></li>
 *       </ol>
 *     </li>
 *     <li> <p>writing attributes : </p>
 *       <ol>
 *        <li><code>virtual void writeAttributes (XMLOutputStream& stream) const </code>
 *         <p>This function must be overridden if one or more additional attributes are defined.</p>
 *        </li>
 *        <li><code>virtual void writeXMLNS (XMLOutputStream& stream) const </code>
 *         <p>This function must be overridden if one or more additional xmlns attributes are defined.</p>
 *        </li>
 *       </ol>
 *     </li>
 * <p>
 *     <li> <p>checking elements (should be overridden) :</p>
 *       <ol>
 *         <li><code>virtual bool hasRequiredElements() const </code></li>
 *       </ol>
 *     </li>
 * <p>
 *     <li> <p>checking attributes (should be overridden) :</p>
 *       <ol>
 *         <li><code>virtual bool hasRequiredAttributes() const </code></li>
 *       </ol>
 *     </li>
 *   </ul>
 * <p>
 *<p>
 *   To implement package-specific creating/getting/manipulating functions of the
 *   {@link SBasePlugin} derived class (e.g., getListOfLayouts(), createLyout(), getLayout(),
 *   and etc are implemented in LayoutModelPlugin class of the layout package), package
 *   developers must newly implement such functions (as they like) in the derived class.
 *</p>
 * <p>
 *<p>
 *   {@link SBasePlugin} class defines other virtual functions of internal implementations
 *   such as:
 * <p>
 *   <ul>
 *    <li><code> virtual void setSBMLDocument(SBMLDocument d) </code>
 *    <li><code> virtual void connectToParent(SBase sbase) </code>
 *    <li><code> virtual void enablePackageInternal(String pkgURI, String pkgPrefix, bool flag) </code>
 *   </ul>
 * <p>
 *   These functions must be overridden by subclasses in which one or more top-level elements are defined.
 *</p>
 * <p>
 *<p>
 *   For example, the following three {@link SBasePlugin} extended classes are implemented in
 *   the layout extension:
 *</p>
 * <p>
 *<ol>
 * <p>
 *  <li> <p><a href='class_s_b_m_l_document_plugin.html'> {@link SBMLDocumentPlugin} </a> class for {@link SBMLDocument} element</p>
 * <p>
 *    <ul>
 *         <li> <em> required </em> attribute is added to {@link SBMLDocument} object.
 *         </li>
 *    </ul>
 * <p>
 *<p>
 *(<a href='class_s_b_m_l_document_plugin.html'> {@link SBMLDocumentPlugin} </a> class is a common {@link SBasePlugin} 
 *extended class for {@link SBMLDocument} class. Package developers can use this class as-is if no additional 
 *elements/attributes (except for <em> required </em> attribute) is needed for the {@link SBMLDocument} class 
 *in their packages, otherwise package developers must implement a new {@link SBMLDocumentPlugin} derived class.)
 *</p>
 * <p>
 *  <li> <p>LayoutModelPlugin class for {@link Model} element</p>
 *    <ul>
 *       <li> &lt;listOfLayouts&gt; element is added to {@link Model} object.
 *       </li>
 * <p>
 *       <li> <p>
 *            The following virtual functions for reading/writing/checking
 *            are overridden: (type of arguments and return values are omitted)
 *            </p>
 *           <ul>
 *              <li> <code> createObject() </code> : (read elements)
 *              </li>
 *              <li> <code> readOtherXML() </code> : (read elements in annotation of SBML L2)
 *              </li>
 *              <li> <code> writeElements() </code> : (write elements)
 *              </li>
 *           </ul>
 *       </li>
 * <p>
 *        <li> <p>
 *             The following virtual functions of internal implementations
 *             are overridden: (type of arguments and return values are omitted)
 *            </p>  
 *            <ul>
 *              <li> <code> setSBMLDocument() </code> 
 *              </li>
 *              <li> <code> connectToParent() </code>
 *              </li>
 *              <li> <code> enablePackageInternal() </code>
 *              </li>
 *            </ul>
 *        </li>
 * <p>
 * <p>
 *        <li> <p>
 *             The following creating/getting/manipulating functions are newly 
 *             implemented: (type of arguments and return values are omitted)
 *            </p>
 *            <ul>
 *              <li> <code> getListOfLayouts() </code>
 *              </li>
 *              <li> <code> getLayout ()  </code>
 *              </li>
 *              <li> <code> addLayout() </code>
 *              </li>
 *              <li> <code> createLayout() </code>
 *              </li>
 *              <li> <code> removeLayout() </code>
 *              </li>	   
 *              <li> <code> getNumLayouts() </code>
 *              </li>
 *           </ul>
 *        </li>
 * <p>
 *    </ul>
 *  </li>
 * <p>
 *  <li> <p>LayoutSpeciesReferencePlugin class for {@link SpeciesReference} element (used only for SBML L2V1) </p>
 * <p>
 *      <ul>
 *        <li>
 *         <em> id </em> attribute is internally added to {@link SpeciesReference} object
 *          only for SBML L2V1 
 *        </li>
 * <p>
 *        <li>
 *         The following virtual functions for reading/writing/checking
 *          are overridden: (type of arguments and return values are omitted)
 *        </li>
 * <p>
 *         <ul>
 *          <li>
 *          <code> readOtherXML() </code>
 *          </li>
 *          <li>
 *          <code> writeAttributes() </code>
 *          </li>
 *        </ul>
 *      </ul>
 *    </li>
 * <p>
 * </ol>
 */

public class SBasePlugin {
   private long swigCPtr;
   protected boolean swigCMemOwn;

   protected SBasePlugin(long cPtr, boolean cMemoryOwn)
   {
     swigCMemOwn = cMemoryOwn;
     swigCPtr    = cPtr;
   }

   protected static long getCPtr(SBasePlugin obj)
   {
     return (obj == null) ? 0 : obj.swigCPtr;
   }

   protected static long getCPtrAndDisown (SBasePlugin obj)
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
        libsbmlJNI.delete_SBasePlugin(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  
/**
   * Returns the XML namespace (URI) of the package extension
   * of this plugin object.
   * <p>
   * @return the URI of the package extension of this plugin object.
   */ public
 String getElementNamespace() {
    return libsbmlJNI.SBasePlugin_getElementNamespace(swigCPtr, this);
  }

  
/**
   * Returns the prefix of the package extension of this plugin object.
   * <p>
   * @return the prefix of the package extension of this plugin object.
   */ public
 String getPrefix() {
    return libsbmlJNI.SBasePlugin_getPrefix(swigCPtr, this);
  }

  
/**
   * Returns the package name of this plugin object.
   * <p>
   * @return the package name of this plugin object.
   */ public
 String getPackageName() {
    return libsbmlJNI.SBasePlugin_getPackageName(swigCPtr, this);
  }

  
/**
   * Creates and returns a deep copy of this {@link SBasePlugin} object.
   * <p>
   * @return a (deep) copy of this {@link SBase} object
   */ public
 SBasePlugin cloneObject() {
	return libsbml.DowncastSBasePlugin(libsbmlJNI.SBasePlugin_cloneObject(swigCPtr, this), true);
}

  
/**
   * Returns the first child element found that has the given <code>id</code> in the model-wide SId namespace, or <code>null</code> if no such object is found.
   * <p>
   * @param id string representing the id of objects to find
   * <p>
   * @return pointer to the first element found with the given <code>id</code>.
   */ public
 SBase getElementBySId(String id) {
  return libsbml.DowncastSBase(libsbmlJNI.SBasePlugin_getElementBySId(swigCPtr, this, id), false);
}

  
/**
   * Returns the first child element it can find with the given <code>metaid</code>, or <code>null</code> if no such object is found.
   * <p>
   * @param metaid string representing the metaid of objects to find
   * <p>
   * @return pointer to the first element found with the given <code>metaid</code>.
   */ public
 SBase getElementByMetaId(String metaid) {
  return libsbml.DowncastSBase(libsbmlJNI.SBasePlugin_getElementByMetaId(swigCPtr, this, metaid), false);
}

  
/**
   * Sets the parent SBML object of this plugin object to
   * this object and child elements (if any).
   * (Creates a child-parent relationship by this plugin object)
   * <p>
   * This function is called when this object is created by
   * the parent element.
   * Subclasses must override this this function if they have one
   * or more child elements. Also, {@link SBasePlugin#connectToParent(SBase sbase)}
   * must be called in the overridden function.
   * <p>
   * @param sbase the {@link SBase} object to use
   * <p>
   * @see setSBMLDocument
   * @see enablePackageInternal
   * @internal
   */ public
 void connectToParent(SBase sbase) {
    libsbmlJNI.SBasePlugin_connectToParent(swigCPtr, this, SBase.getCPtr(sbase), sbase);
  }

  
/**
   * Enables/Disables the given package with child elements in this plugin 
   * object (if any).
   * (This is an internal implementation invoked from 
   *  {@link SBase#enablePackageInternal()} function)
   * <p>
   * Subclasses which contain one or more {@link SBase} derived elements should 
   * override this function if elements defined in them can be extended by
   * some other package extension.
   * <p>
   * @see setSBMLDocument
   * @see connectToParent
   * @internal
   */ public
 void enablePackageInternal(String pkgURI, String pkgPrefix, boolean flag) {
    libsbmlJNI.SBasePlugin_enablePackageInternal(swigCPtr, this, pkgURI, pkgPrefix, flag);
  }

  
/**
   * Enables/Disables the given package with child elements in this plugin 
   * object (if any).
   * (This is an internal implementation invoked from 
   *  {@link SBase#enablePackageInternal()} function)
   * <p>
   * Subclasses which contain one or more {@link SBase} derived elements should 
   * override this function if elements defined in them can be extended by
   * some other package extension.
   * <p>
   * @see setSBMLDocument
   * @see connectToParent
   * @internal
   */ public
 boolean stripPackage(String pkgPrefix, boolean flag) {
    return libsbmlJNI.SBasePlugin_stripPackage(swigCPtr, this, pkgPrefix, flag);
  }

  
/**
   * Returns the parent {@link SBMLDocument} of this plugin object.
   * <p>
   * @return the parent {@link SBMLDocument} object of this plugin object.
   */ public
 SBMLDocument getSBMLDocument() {
    long cPtr = libsbmlJNI.SBasePlugin_getSBMLDocument__SWIG_0(swigCPtr, this);
    return (cPtr == 0) ? null : new SBMLDocument(cPtr, false);
  }

  
/**
   * Gets the URI to which this element belongs to.
   * For example, all elements that belong to SBML Level 3 Version 1 Core
   * must would have the URI 'http://www.sbml.org/sbml/level3/version1/core'; 
   * all elements that belong to Layout Extension Version 1 for SBML Level 3
   * Version 1 Core must would have the URI
   * 'http://www.sbml.org/sbml/level3/version1/layout/version1/'
   * <p>
   * Unlike getElementNamespace, this function first returns the URI for this 
   * element by looking into the {@link SBMLNamespaces} object of the document with 
   * the its package name. if not found it will return the result of 
   * getElementNamespace
   * <p>
   * @return the URI this elements  
   * <p>
   * @see getPackageName
   * @see getElementNamespace
   * @see SBMLDocument#getSBMLNamespaces
   * @see getSBMLDocument
   */ public
 String getURI() {
    return libsbmlJNI.SBasePlugin_getURI(swigCPtr, this);
  }

  
/**
   * Returns the parent {@link SBase} object to which this plugin 
   * object connected.
   * <p>
   * @return the parent {@link SBase} object to which this plugin 
   * object connected.
   */ public
 SBase getParentSBMLObject() {
  return libsbml.DowncastSBase(libsbmlJNI.SBasePlugin_getParentSBMLObject__SWIG_0(swigCPtr, this), false);
}

  
/**
   * Sets the XML namespace to which this element belongs to.
   * For example, all elements that belong to SBML Level 3 Version 1 Core
   * must set the namespace to 'http://www.sbml.org/sbml/level3/version1/core'; 
   * all elements that belong to Layout Extension Version 1 for SBML Level 3
   * Version 1 Core must set the namespace to 
   * 'http://www.sbml.org/sbml/level3/version1/layout/version1/'
   * <p>
   * @return integer value indicating success/failure of the
   * function.   The possible values
   * returned by this function are:
   * <ul>
   * <li> {@link  libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS }
   * <li> {@link  libsbmlConstants#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE }
   * </ul>
   */ public
 int setElementNamespace(String uri) {
    return libsbmlJNI.SBasePlugin_setElementNamespace(swigCPtr, this, uri);
  }

  
/**
   * Returns the SBML level of the package extension of 
   * this plugin object.
   * <p>
   * @return the SBML level of the package extension of
   * this plugin object.
   */ public
 long getLevel() {
    return libsbmlJNI.SBasePlugin_getLevel(swigCPtr, this);
  }

  
/**
   * Returns the SBML version of the package extension of
   * this plugin object.
   * <p>
   * @return the SBML version of the package extension of
   * this plugin object.
   */ public
 long getVersion() {
    return libsbmlJNI.SBasePlugin_getVersion(swigCPtr, this);
  }

  
/**
   * Returns the package version of the package extension of
   * this plugin object.
   * <p>
   * @return the package version of the package extension of
   * this plugin object.
   */ public
 long getPackageVersion() {
    return libsbmlJNI.SBasePlugin_getPackageVersion(swigCPtr, this);
  }

  
/**
   * If this object has a child 'math' object (or anything with ASTNodes in general), replace all nodes with the name 'id' with the provided function. 
   * <p>
   * @note This function does nothing itself--subclasses with {@link ASTNode} subelements must override this function.
   * @internal
   */ public
 void replaceSIDWithFunction(String id, ASTNode function) {
    libsbmlJNI.SBasePlugin_replaceSIDWithFunction(swigCPtr, this, id, ASTNode.getCPtr(function), function);
  }

  
/**
   * If the function of this object is to assign a value has a child 'math' object (or anything with ASTNodes in general), replace  the 'math' object with the function (existing/function).  
   * <p>
   * @note This function does nothing itself--subclasses with {@link ASTNode} subelements must override this function.
   * @internal
   */ public
 void divideAssignmentsToSIdByFunction(String id, ASTNode function) {
    libsbmlJNI.SBasePlugin_divideAssignmentsToSIdByFunction(swigCPtr, this, id, ASTNode.getCPtr(function), function);
  }

  
/**
   * If this assignment assigns a value to the 'id' element, replace the 'math' object with the function (existing*function). 
   * @internal 
   */ public
 void multiplyAssignmentsToSIdByFunction(String id, ASTNode function) {
    libsbmlJNI.SBasePlugin_multiplyAssignmentsToSIdByFunction(swigCPtr, this, id, ASTNode.getCPtr(function), function);
  }

  
/**
   * Check to see if the given prefix is used by any of the IDs defined by extension elements.  A package that defines its own 'id' attribute for a core element would check that attribute here.
   * @internal
   */ public
 boolean hasIdentifierBeginningWith(String prefix) {
    return libsbmlJNI.SBasePlugin_hasIdentifierBeginningWith(swigCPtr, this, prefix);
  }

  
/**
   * Add the given string to all identifiers in the object.  If the string is added to anything other than an id or a metaid, this code is responsible for tracking down and renaming all *idRefs in the package extention that identifier comes from.
   * @internal
   */ public
 int prependStringToAllIdentifiers(String prefix) {
    return libsbmlJNI.SBasePlugin_prependStringToAllIdentifiers(swigCPtr, this, prefix);
  }

  
/**
   * Returns the line number on which this object first appears in the XML
   * representation of the SBML document.
   * <p>
   * @return the line number of the underlying SBML object.
   * <p>
   * @note The line number for each construct in an SBML model is set upon
   * reading the model.  The accuracy of the line number depends on the
   * correctness of the XML representation of the model, and on the
   * particular XML parser library being used.  The former limitation
   * relates to the following problem: if the model is actually invalid
   * XML, then the parser may not be able to interpret the data correctly
   * and consequently may not be able to establish the real line number.
   * The latter limitation is simply that different parsers seem to have
   * their own accuracy limitations, and out of all the parsers supported
   * by libSBML, none have been 100% accurate in all situations. (At this
   * time, libSBML supports the use of <a target='_blank'
   * href='http://xmlsoft.org'>libxml2</a>, <a target='_blank'
   * href='http://expat.sourceforge.net/'>Expat</a> and <a target='_blank'
   * href='http://xerces.apache.org/xerces-c/'>Xerces</a>.)
   * <p>
   * @see #getColumn()
   * @internal
   */ public
 long getLine() {
    return libsbmlJNI.SBasePlugin_getLine(swigCPtr, this);
  }

  
/**
   * Returns the column number on which this object first appears in the XML
   * representation of the SBML document.
   * <p>
   * @return the column number of the underlying SBML object.
   * <p>
   * @note The column number for each construct in an SBML model is set
   * upon reading the model.  The accuracy of the column number depends on
   * the correctness of the XML representation of the model, and on the
   * particular XML parser library being used.  The former limitation
   * relates to the following problem: if the model is actually invalid
   * XML, then the parser may not be able to interpret the data correctly
   * and consequently may not be able to establish the real column number.
   * The latter limitation is simply that different parsers seem to have
   * their own accuracy limitations, and out of all the parsers supported
   * by libSBML, none have been 100% accurate in all situations. (At this
   * time, libSBML supports the use of <a target='_blank'
   * href='http://xmlsoft.org'>libxml2</a>, <a target='_blank'
   * href='http://expat.sourceforge.net/'>Expat</a> and <a target='_blank'
   * href='http://xerces.apache.org/xerces-c/'>Xerces</a>.)
   * <p>
   * @see #getLine()
   * @internal
   */ public
 long getColumn() {
    return libsbmlJNI.SBasePlugin_getColumn(swigCPtr, this);
  }

  
/**
   * Returns the column number on which this object first appears in the XML
   * representation of the SBML document.
   * <p>
   * @return the column number of the underlying SBML object.
   * <p>
   * @note The column number for each construct in an SBML model is set
   * upon reading the model.  The accuracy of the column number depends on
   * the correctness of the XML representation of the model, and on the
   * particular XML parser library being used.  The former limitation
   * relates to the following problem: if the model is actually invalid
   * XML, then the parser may not be able to interpret the data correctly
   * and consequently may not be able to establish the real column number.
   * The latter limitation is simply that different parsers seem to have
   * their own accuracy limitations, and out of all the parsers supported
   * by libSBML, none have been 100% accurate in all situations. (At this
   * time, libSBML supports the use of <a target='_blank'
   * href='http://xmlsoft.org'>libxml2</a>, <a target='_blank'
   * href='http://expat.sourceforge.net/'>Expat</a> and <a target='_blank'
   * href='http://xerces.apache.org/xerces-c/'>Xerces</a>.)
   * <p>
   * @see #getLine()
   * @internal
   */ public
 SBMLNamespaces getSBMLNamespaces() {
  return libsbml.DowncastSBMLNamespaces(libsbmlJNI.SBasePlugin_getSBMLNamespaces(swigCPtr, this), false);
}

  
/**
   * Helper to log a common type of error for elements.
   * @internal
   */ public
 void logUnknownElement(String element, long sbmlLevel, long sbmlVersion, long pkgVersion) {
    libsbmlJNI.SBasePlugin_logUnknownElement(swigCPtr, this, element, sbmlLevel, sbmlVersion, pkgVersion);
  }

  
  /**
   * Returns an {@link SBaseList} of all child {@link SBase} objects,
   * including those nested to an arbitrary depth.
   *
   * @return a pointer to an {@link SBaseList} of pointers to all children objects.
   */
 public SBaseList getListOfAllElements() {
    long cPtr = libsbmlJNI.SBasePlugin_getListOfAllElements(swigCPtr, this);
    return (cPtr == 0) ? null : new SBaseList(cPtr, false);
  }

}
