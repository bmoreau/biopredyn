/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.6
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace libsbml {

 using System;
 using System.Runtime.InteropServices;

/** 
 * @ingroup Core
 * Log of errors and other events encountered during SBML processing.
 *
 * @htmlinclude not-sbml-warning.html
 *
 * The error log is a list.  Each SBMLDocument maintains its own
 * SBMLErrorLog.  When a libSBML operation on SBML content results in an
 * error, or when there is something worth noting about the SBML content,
 * the issue is reported as an SBMLError object stored in the SBMLErrorLog
 * list.
 *
 * SBMLErrorLog is derived from XMLErrorLog, an object class that serves
 * exactly the same purpose but for the XML parsing layer.  XMLErrorLog
 * provides crucial methods such as
 * @if java XMLErrorLog::getNumErrors()@else getNumErrors()@endif@~
 * for determining how many SBMLError or XMLError objects are in the log.
 * SBMLErrorLog inherits these methods.
 *
 * The general approach to working with SBMLErrorLog in user programs
 * involves first obtaining a pointer to a log from a libSBML object such
 * as SBMLDocument.  Callers should then use
 * @if java XMLErrorLog::getNumErrors()@else getNumErrors() @endif@~ to inquire how
 * many objects there are in the list.  (The answer may be 0.)  If there is
 * at least one SBMLError object in the SBMLErrorLog instance, callers can
 * then iterate over the list using
 * SBMLErrorLog::getError(@if java long n@endif)@if clike const@endif,
 * using methods provided by the SBMLError class to find out the error code
 * and associated information such as the error severity, the message, and
 * the line number in the input.
 *
 * If you wish to simply print the error strings for a human to read, an
 * easier and more direct way might be to use SBMLDocument::printErrors().
 *
 * @see SBMLError
 * @see XMLErrorLog
 * @see XMLError
 */

public class SBMLErrorLog : XMLErrorLog {
	private HandleRef swigCPtr;
	
	internal SBMLErrorLog(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.SBMLErrorLog_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.SBMLErrorLogUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(SBMLErrorLog obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (SBMLErrorLog obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~SBMLErrorLog() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_SBMLErrorLog(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/**
   * Returns the <i>n</i>th SBMLError object in this log.
   *
   * Index @p n is counted from 0.  Callers should first inquire about the
   * number of items in the log by using the
   * @if java XMLErrorLog::getNumErrors()@else getNumErrors()@endif@~ method.
   * Attempts to use an error index number that exceeds the actual number
   * of errors in the log will result in a @c null being returned.
   *
   * @param n the index number of the error to retrieve (with 0 being the
   * first error).
   *
   * @return the <i>n</i>th SBMLError in this log, or @c null if @p n is
   * greater than or equal to
   * @if java XMLErrorLog::getNumErrors()@else getNumErrors()@endif.
   *
   * @see getNumErrors()
   */ public new
 SBMLError getError(long n) {
    IntPtr cPtr = libsbmlPINVOKE.SBMLErrorLog_getError(swigCPtr, n);
    SBMLError ret = (cPtr == IntPtr.Zero) ? null : new SBMLError(cPtr, false);
    return ret;
  }

  
/**
   * Returns the number of errors that have been logged with the given
   * severity code.
   *
   * LibSBML associates severity levels with every SBMLError object to
   * provide an indication of how serious the problem is.  Severities range
   * from informational diagnostics to fatal (irrecoverable) errors.  Given
   * an SBMLError object instance, a caller can interrogate it for its
   * severity level using methods such as SBMLError::getSeverity(),
   * SBMLError::isFatal(), and so on.  The present method encapsulates
   * iteration and interrogation of all objects in an SBMLErrorLog, making
   * it easy to check for the presence of error objects with specific
   * severity levels.
   *
   * @if clike @param severity a value from
   * #SBMLErrorSeverity_t @endif@if java @param severity a
   * value from the set of <c>LIBSBML_SEV_</c> constants defined by
   * the interface class <c><a
   * href='libsbmlcs.libsbml.html'>libsbmlConstants</a></c> @endif@if python @param severity a
   * value from the set of <c>LIBSBML_SEV_</c> constants defined by
   * the interface class @link libsbml libsbml@endlink. @endif@~
   *
   * @return a count of the number of errors with the given severity code.
   *
   * @see getNumErrors()
   */ public
 long getNumFailsWithSeverity(long severity) { return (long)libsbmlPINVOKE.SBMLErrorLog_getNumFailsWithSeverity__SWIG_0(swigCPtr, severity); }

  
/**
   * Creates a new, empty SBMLErrorLog.
   */ /* libsbml-internal */ public
 SBMLErrorLog() : this(libsbmlPINVOKE.new_SBMLErrorLog(), true) {
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logError(long errorId, long level, long version, string details, long line, long column, long severity, long category) {
    libsbmlPINVOKE.SBMLErrorLog_logError__SWIG_0(swigCPtr, errorId, level, version, details, line, column, severity, category);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logError(long errorId, long level, long version, string details, long line, long column, long severity) {
    libsbmlPINVOKE.SBMLErrorLog_logError__SWIG_1(swigCPtr, errorId, level, version, details, line, column, severity);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logError(long errorId, long level, long version, string details, long line, long column) {
    libsbmlPINVOKE.SBMLErrorLog_logError__SWIG_2(swigCPtr, errorId, level, version, details, line, column);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logError(long errorId, long level, long version, string details, long line) {
    libsbmlPINVOKE.SBMLErrorLog_logError__SWIG_3(swigCPtr, errorId, level, version, details, line);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logError(long errorId, long level, long version, string details) {
    libsbmlPINVOKE.SBMLErrorLog_logError__SWIG_4(swigCPtr, errorId, level, version, details);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logError(long errorId, long level, long version) {
    libsbmlPINVOKE.SBMLErrorLog_logError__SWIG_5(swigCPtr, errorId, level, version);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logError(long errorId, long level) {
    libsbmlPINVOKE.SBMLErrorLog_logError__SWIG_6(swigCPtr, errorId, level);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logError(long errorId) {
    libsbmlPINVOKE.SBMLErrorLog_logError__SWIG_7(swigCPtr, errorId);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logError() {
    libsbmlPINVOKE.SBMLErrorLog_logError__SWIG_8(swigCPtr);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logPackageError(string package, long errorId, long pkgVersion, long level, long version, string details, long line, long column, long severity, long category) {
    libsbmlPINVOKE.SBMLErrorLog_logPackageError__SWIG_0(swigCPtr, package, errorId, pkgVersion, level, version, details, line, column, severity, category);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logPackageError(string package, long errorId, long pkgVersion, long level, long version, string details, long line, long column, long severity) {
    libsbmlPINVOKE.SBMLErrorLog_logPackageError__SWIG_1(swigCPtr, package, errorId, pkgVersion, level, version, details, line, column, severity);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logPackageError(string package, long errorId, long pkgVersion, long level, long version, string details, long line, long column) {
    libsbmlPINVOKE.SBMLErrorLog_logPackageError__SWIG_2(swigCPtr, package, errorId, pkgVersion, level, version, details, line, column);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logPackageError(string package, long errorId, long pkgVersion, long level, long version, string details, long line) {
    libsbmlPINVOKE.SBMLErrorLog_logPackageError__SWIG_3(swigCPtr, package, errorId, pkgVersion, level, version, details, line);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logPackageError(string package, long errorId, long pkgVersion, long level, long version, string details) {
    libsbmlPINVOKE.SBMLErrorLog_logPackageError__SWIG_4(swigCPtr, package, errorId, pkgVersion, level, version, details);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logPackageError(string package, long errorId, long pkgVersion, long level, long version) {
    libsbmlPINVOKE.SBMLErrorLog_logPackageError__SWIG_5(swigCPtr, package, errorId, pkgVersion, level, version);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logPackageError(string package, long errorId, long pkgVersion, long level) {
    libsbmlPINVOKE.SBMLErrorLog_logPackageError__SWIG_6(swigCPtr, package, errorId, pkgVersion, level);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logPackageError(string package, long errorId, long pkgVersion) {
    libsbmlPINVOKE.SBMLErrorLog_logPackageError__SWIG_7(swigCPtr, package, errorId, pkgVersion);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logPackageError(string package, long errorId) {
    libsbmlPINVOKE.SBMLErrorLog_logPackageError__SWIG_8(swigCPtr, package, errorId);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logPackageError(string package) {
    libsbmlPINVOKE.SBMLErrorLog_logPackageError__SWIG_9(swigCPtr, package);
  }

  
/**
   * Convenience function that combines creating an SBMLError object and
   * adding it to the log.
   *
   * @param errorId a long integer, the identification number of the error.
   *
   * @param level a long integer, the SBML Level
   *
   * @param version a long integer, the SBML Level's Version
   * 
   * @param details a string containing additional details about the error.
   * If the error code in @p errorId is one that is recognized by SBMLError,
   * the given message is @em appended to a predefined message associated
   * with the given code.  If the error code is not recognized, the message
   * is stored as-is as the text of the error.
   * 
   * @param line a long integer, the line number at which the error occured.
   * 
   * @param column a long integer, the column number at which the error occured.
   * 
   * @param severity an integer indicating severity of the error.
   * 
   * @param category an integer indicating the category to which the error
   * belongs.
   *
   * @if notcpp @htmlinclude warn-default-args-in-docs.html @endif@~
   */ /* libsbml-internal */ public
 void logPackageError() {
    libsbmlPINVOKE.SBMLErrorLog_logPackageError__SWIG_10(swigCPtr);
  }

  
/**
   * Adds the given SBMLError to the log.
   *
   * @param error SBMLError, the error to be logged.
   */ /* libsbml-internal */ public
 void add(SBMLError error) {
    libsbmlPINVOKE.SBMLErrorLog_add(swigCPtr, SBMLError.getCPtr(error));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Removes an error having errorId from the SBMLError list.
   *  
   * Only the first item will be removed if there are multiple errors
   * with the given errorId.
   *
   * @param errorId the error identifier of the error to be removed.
   */ public
 void remove(long errorId) {
    libsbmlPINVOKE.SBMLErrorLog_remove(swigCPtr, errorId);
  }

  
/**
   * Returns true if SBMLErrorLog contains an errorId
   *
   * @param errorId the error identifier of the error to be found.
   */ public
 bool contains(long errorId) {
    bool ret = libsbmlPINVOKE.SBMLErrorLog_contains(swigCPtr, errorId);
    return ret;
  }

}

}
