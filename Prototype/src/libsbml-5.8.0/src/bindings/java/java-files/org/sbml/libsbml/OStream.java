/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.6
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.sbml.libsbml;

/** 
 * Wrapper class for the C++ standard streams <code>cout</code>,
 * <code>cerr</code>, and <code>clog</code>.
 * <p>
 * A few libSBML methods accept an argument for indicating where to send
 * text string output.  An example is the {@link SBMLDocument#printErrors(OStream
 * stream)} method. However, the methods use C++ style streams and not Java
 * stream objects.  The {@link OStream} object exists to bridge the Java and
 * underlying native implementation.  It is a simple wrapper around the
 * underlying stream object and provides a few basic methods for
 * manipulating it.
 * <p>
 */

public class OStream {
   private long swigCPtr;
   protected boolean swigCMemOwn;

   protected OStream(long cPtr, boolean cMemoryOwn)
   {
     swigCMemOwn = cMemoryOwn;
     swigCPtr    = cPtr;
   }

   protected static long getCPtr(OStream obj)
   {
     return (obj == null) ? 0 : obj.swigCPtr;
   }

   protected static long getCPtrAndDisown (OStream obj)
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
        libsbmlJNI.delete_OStream(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  
/**
      * Creates a new {@link OStream} object with one of standard output stream objects.
      * <p>
      * @param sot a value from the StdOSType enumeration(COUT, CERR, or CLOG) 
			* indicating the type of stream to create.
      */ public
 OStream(int sot) {
    this(libsbmlJNI.new_OStream__SWIG_0(sot), true);
  }

  
/**
      * Creates a new {@link OStream} object with one of standard output stream objects.
      * <p>
      * @param sot a value from the StdOSType enumeration(COUT, CERR, or CLOG) 
			* indicating the type of stream to create.
      */ public
 OStream() {
    this(libsbmlJNI.new_OStream__SWIG_1(), true);
  }

  
/**
     * Returns the stream object.
     * <p>
     * @return the stream object
     */ public
 SWIGTYPE_p_std__ostream get_ostream() {
    long cPtr = libsbmlJNI.OStream_get_ostream(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_std__ostream(cPtr, false);
  }

  
/**
     * Writes an end-of-line character on this tream.
     */ public
 void endl() {
    libsbmlJNI.OStream_endl(swigCPtr, this);
  }

  // StdOSType 
  public final static int COUT = 0;
  public final static int CERR = COUT + 1;
  public final static int CLOG = CERR + 1;

}
