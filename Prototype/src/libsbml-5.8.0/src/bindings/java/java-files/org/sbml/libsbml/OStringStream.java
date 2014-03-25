/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.6
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.sbml.libsbml;

/** 
 * Wrapper class for the C++ standard stream <code>ostringstream</code>.
 * <p>
 * The C++ <code>ostringstream</code> ('output string stream class')
 * provides an interface to manipulating strings as if they were output
 * streams.  This class class, {@link OStringStream}, wraps the
 * <code>ostringstream</code> and provides an {@link OStream} interface to it.
 * <p>
 * This class may be useful because some libSBML methods accept an argument
 * for indicating where to send text string output.  An example is the 
 * {@link SBMLDocument#printErrors(OStream stream)} method.  The methods use
 * C++ style streams and not Java stream objects.  The {@link OStream} object
 * exists to bridge the Java and underlying native implementation.  It is a
 * simple wrapper around the underlying stream object and provides a few
 * basic methods for manipulating it.
 */

public class OStringStream extends OStream {
   private long swigCPtr;

   protected OStringStream(long cPtr, boolean cMemoryOwn)
   {
     super(libsbmlJNI.OStringStream_SWIGUpcast(cPtr), cMemoryOwn);
     swigCPtr = cPtr;
   }

   protected static long getCPtr(OStringStream obj)
   {
     return (obj == null) ? 0 : obj.swigCPtr;
   }

   protected static long getCPtrAndDisown (OStringStream obj)
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
        libsbmlJNI.delete_OStringStream(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  
/**
     * Creates a new {@link OStringStream} object
     */ public
 OStringStream() {
    this(libsbmlJNI.new_OStringStream(), true);
  }

  
/**
     * Returns the copy of the string object currently assosiated 
     * with this <code>ostringstream</code> buffer.
     * <p>
     * @return a copy of the string object for this stream
     */ public
 String str() {
    return libsbmlJNI.OStringStream_str__SWIG_0(swigCPtr, this);
  }

  
/**
     * Sets string <code>s</code> to the string object currently assosiated with
     * this stream buffer.
     * <p>
     * @param s the string to write to this stream
     */ public
 void str(String s) {
    libsbmlJNI.OStringStream_str__SWIG_1(swigCPtr, this, s);
  }

}
