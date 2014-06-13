/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace libsbmlcs {

 using System;
 using System.Runtime.InteropServices;

/** 
 * @sbmlpackage{core}
 *
@htmlinclude pkg-marker-core.html Representation of a qualified XML name.
 *
 * @htmlinclude not-sbml-warning.html
 *
 * A 'triple' in the libSBML XML layer encapsulates the notion of qualified
 * name, meaning an element name or an attribute name with an optional
 * namespace qualifier.  An XMLTriple instance carries up to three data items:
 * 
 * <ul>
 *
 * <li> The name of the attribute or element; that is, the attribute name
 * as it appears in an XML document or data stream;
 *
 * <li> The XML namespace prefix (if any) of the attribute.  For example,
 * in the following fragment of XML, the namespace prefix is the string
 * <code>mysim</code> and it appears on both the element
 * <code>someelement</code> and the attribute <code>attribA</code>.  When
 * both the element and the attribute are stored as XMLTriple objects,
 * their <i>prefix</i> is <code>mysim</code>.
 * @verbatim
<mysim:someelement mysim:attribA='value' />
@endverbatim
 *
 * <li> The XML namespace URI with which the prefix is associated.  In
 * XML, every namespace used must be declared and mapped to a URI.
 *
 * </ul>
 *
 * XMLTriple objects are the lowest-level data item in the XML layer
 * of libSBML.  Other objects such as XMLToken make use of XMLTriple
 * objects.
 */

public class XMLTriple : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal XMLTriple(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(XMLTriple obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (XMLTriple obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~XMLTriple() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_XMLTriple(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
/**
   * Creates a new, empty XMLTriple.
   */ public
 XMLTriple() : this(libsbmlPINVOKE.new_XMLTriple__SWIG_0(), true) {
  }

  
/**
   * Creates a new XMLTriple with the given @p name, @p uri and and @p
   * prefix.
   *
   * @param name a string, name for the XMLTriple.
   * @param uri a string, URI of the XMLTriple.
   * @param prefix a string, prefix for the URI of the XMLTriple,
   *
   * @throws @if python ValueError @else XMLConstructorException @endif
   * Thrown if the argument @p orig is @c null.
   */ public
 XMLTriple(string name, string uri, string prefix) : this(libsbmlPINVOKE.new_XMLTriple__SWIG_1(name, uri, prefix), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new XMLTriple by splitting the given @p triplet on the
   * separator character @p sepchar.
   *
   * Triplet may be in one of the following formats:
   * <ul>
   * <li> name
   * <li> URI sepchar name
   * <li> URI sepchar name sepchar prefix
   * </ul>
   * @param triplet a string representing the triplet as above
   * @param sepchar a character, the sepchar used in the triplet
   *
   * @throws @if python ValueError @else XMLConstructorException @endif
   * Thrown if the argument @p orig is @c null.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLTriple(string triplet, char sepchar) : this(libsbmlPINVOKE.new_XMLTriple__SWIG_2(triplet, sepchar), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new XMLTriple by splitting the given @p triplet on the
   * separator character @p sepchar.
   *
   * Triplet may be in one of the following formats:
   * <ul>
   * <li> name
   * <li> URI sepchar name
   * <li> URI sepchar name sepchar prefix
   * </ul>
   * @param triplet a string representing the triplet as above
   * @param sepchar a character, the sepchar used in the triplet
   *
   * @throws @if python ValueError @else XMLConstructorException @endif
   * Thrown if the argument @p orig is @c null.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLTriple(string triplet) : this(libsbmlPINVOKE.new_XMLTriple__SWIG_3(triplet), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Copy constructor; creates a copy of this XMLTriple set.
   *
   * @param orig the XMLTriple object to copy.
   *
   * @throws @if python ValueError @else XMLConstructorException @endif
   * Thrown if the argument @p orig is @c null.
   */ public
 XMLTriple(XMLTriple orig) : this(libsbmlPINVOKE.new_XMLTriple__SWIG_4(XMLTriple.getCPtr(orig)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this XMLTriple set.
   * 
   * @return a (deep) copy of this XMLTriple set.
   */ public
 XMLTriple clone() {
    IntPtr cPtr = libsbmlPINVOKE.XMLTriple_clone(swigCPtr);
    XMLTriple ret = (cPtr == IntPtr.Zero) ? null : new XMLTriple(cPtr, true);
    return ret;
  }

  
/**
   * Returns the @em name portion of this XMLTriple.
   *
   * @return a string, the name from this XMLTriple.
   */ public
 string getName() {
    string ret = libsbmlPINVOKE.XMLTriple_getName(swigCPtr);
    return ret;
  }

  
/**
   * Returns the @em prefix portion of this XMLTriple.
   *
   * @return a string, the @em prefix portion of this XMLTriple.
   */ public
 string getPrefix() {
    string ret = libsbmlPINVOKE.XMLTriple_getPrefix(swigCPtr);
    return ret;
  }

  
/**
   * Returns the @em URI portion of this XMLTriple.
   *
   * @return URI a string, the @em prefix portion of this XMLTriple.
   */ public
 string getURI() {
    string ret = libsbmlPINVOKE.XMLTriple_getURI(swigCPtr);
    return ret;
  }

  
/**
   * Returns the prefixed name from this XMLTriple.
   *
   * @return a string, the prefixed name from this XMLTriple.
   */ public
 string getPrefixedName() {
    string ret = libsbmlPINVOKE.XMLTriple_getPrefixedName(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true or @c false depending on whether 
   * this XMLTriple is empty.
   * 
   * @return @c true if this XMLTriple is empty, @c false otherwise.
   */ public
 bool isEmpty() {
    bool ret = libsbmlPINVOKE.XMLTriple_isEmpty(swigCPtr);
    return ret;
  }

}

}
