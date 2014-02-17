/**
 * @file:   SedSubTask.h
 * @brief:  Implementation of the SedSubTask class
 * @author: Frank T. Bergmann
 *
 * <!--------------------------------------------------------------------------
 * This file is part of libSEDML.  Please visit http://sed-ml.org for more
 * information about SEDML, and the latest version of libSEDML.
 *
 * Copyright (c) 2013, Frank T. Bergmann  
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met: 
 * 
 * 1. Redistributions of source code must retain the above copyright notice, this
 *    list of conditions and the following disclaimer. 
 * 2. Redistributions in binary form must reproduce the above copyright notice,
 *    this list of conditions and the following disclaimer in the documentation
 *    and/or other materials provided with the distribution. 
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
 * ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * ------------------------------------------------------------------------ -->
 */


#ifndef SedSubTask_H__
#define SedSubTask_H__


#include <sedml/common/extern.h>
#include <sedml/common/sedmlfwd.h>


#ifdef __cplusplus


#include <string>


#include <sedml/SedBase.h>
#include <sedml/SedListOf.h>
#include <sedml/SedNamespaces.h>


LIBSEDML_CPP_NAMESPACE_BEGIN




class LIBSEDML_EXTERN SedSubTask : public SedBase
{

protected:

	int           mOrder;
	bool          mIsSetOrder;
	std::string   mTask;


public:

	/**
	 * Creates a new SedSubTask with the given level, version, and package version.
	 *
	 * @param level an unsigned int, the SEDML Level to assign to this SedSubTask
	 *
	 * @param version an unsigned int, the SEDML Version to assign to this SedSubTask
	 *
	 * @param pkgVersion an unsigned int, the SEDML Sed Version to assign to this SedSubTask
	 */
	SedSubTask(unsigned int level      = SEDML_DEFAULT_LEVEL,
	           unsigned int version    = SEDML_DEFAULT_VERSION);


	/**
	 * Creates a new SedSubTask with the given SedNamespaces object.
	 *
	 * @param sedns the SedNamespaces object
	 */
	SedSubTask(SedNamespaces* sedns);


 	/**
	 * Copy constructor for SedSubTask.
	 *
	 * @param orig; the SedSubTask instance to copy.
	 */
	SedSubTask(const SedSubTask& orig);


 	/**
	 * Assignment operator for SedSubTask.
	 *
	 * @param rhs; the object whose values are used as the basis
	 * of the assignment
	 */
	SedSubTask& operator=(const SedSubTask& rhs);


 	/**
	 * Creates and returns a deep copy of this SedSubTask object.
	 *
	 * @return a (deep) copy of this SedSubTask object.
	 */
	virtual SedSubTask* clone () const;


 	/**
	 * Destructor for SedSubTask.
	 */
	virtual ~SedSubTask();


 	/**
	 * Returns the value of the "order" attribute of this SedSubTask.
	 *
	 * @return the value of the "order" attribute of this SedSubTask as a integer.
	 */
	virtual const int getOrder() const;


	/**
	 * Predicate returning @c true or @c false depending on whether this
	 * SedSubTask's "order" attribute has been set.
	 *
	 * @return @c true if this SedSubTask's "order" attribute has been set,
	 * otherwise @c false is returned.
	 */
	virtual bool isSetOrder() const;


	/**
	 * Sets the value of the "order" attribute of this SedSubTask.
	 *
	 * @param order; int value of the "order" attribute to be set
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSEDML_OPERATION_SUCCESS
	 * @li LIBSEDML_INVALID_ATTRIBUTE_VALUE
	 */
	virtual int setOrder(int order);


	/**
	 * Unsets the value of the "order" attribute of this SedSubTask.
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSEDML_OPERATION_SUCCESS
	 * @li LIBSEDML_OPERATION_FAILED
	 */
	virtual int unsetOrder();


	/**
	 * Returns the value of the "task" attribute of this SedSubTask.
	 *
	 * @return the value of the "task" attribute of this SedSubTask as a string.
	 */
	virtual const std::string& getTask() const;


	/**
	 * Predicate returning @c true or @c false depending on whether this
	 * SedSubTask's "task" attribute has been set.
	 *
	 * @return @c true if this SedSubTask's "task" attribute has been set,
	 * otherwise @c false is returned.
	 */
	virtual bool isSetTask() const;


	/**
	 * Sets the value of the "task" attribute of this SedSubTask.
	 *
	 * @param task; const std::string& value of the "task" attribute to be set
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSEDML_OPERATION_SUCCESS
	 * @li LIBSEDML_INVALID_ATTRIBUTE_VALUE
	 */
	virtual int setTask(const std::string& task);


	/**
	 * Unsets the value of the "task" attribute of this SedSubTask.
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSEDML_OPERATION_SUCCESS
	 * @li LIBSEDML_OPERATION_FAILED
	 */
	virtual int unsetTask();


	/**
	 * Returns the XML element name of this object, which for SedSubTask, is
	 * always @c "sedSubTask".
	 *
	 * @return the name of this element, i.e. @c "sedSubTask".
	 */
	virtual const std::string& getElementName () const;


	/**
	 * Returns the libSEDML type code for this SEDML object.
	 * 
	 * @if clike LibSEDML attaches an identifying code to every kind of SEDML
	 * object.  These are known as <em>SEDML type codes</em>.  The set of
	 * possible type codes is defined in the enumeration #SEDMLTypeCode_t.
	 * The names of the type codes all begin with the characters @c
	 * SEDML_. @endif@if java LibSEDML attaches an identifying code to every
	 * kind of SEDML object.  These are known as <em>SEDML type codes</em>.  In
	 * other languages, the set of type codes is stored in an enumeration; in
	 * the Java language interface for libSEDML, the type codes are defined as
	 * static integer constants in the interface class {@link
	 * libsbmlConstants}.  The names of the type codes all begin with the
	 * characters @c SEDML_. @endif@if python LibSEDML attaches an identifying
	 * code to every kind of SEDML object.  These are known as <em>SEDML type
	 * codes</em>.  In the Python language interface for libSEDML, the type
	 * codes are defined as static integer constants in the interface class
	 * @link libsbml@endlink.  The names of the type codes all begin with the
	 * characters @c SEDML_. @endif@if csharp LibSEDML attaches an identifying
	 * code to every kind of SEDML object.  These are known as <em>SEDML type
	 * codes</em>.  In the C# language interface for libSEDML, the type codes
	 * are defined as static integer constants in the interface class @link
	 * libsbmlcs.libsbml@endlink.  The names of the type codes all begin with
	 * the characters @c SEDML_. @endif
	 *
	 * @return the SEDML type code for this object, or
	 * @link SEDMLTypeCode_t#SEDML_UNKNOWN SEDML_UNKNOWN@endlink (default).
	 *
	 * @see getElementName()
	 */
	virtual int getTypeCode () const;


	/**
	 * Predicate returning @c true if all the required attributes
	 * for this SedSubTask object have been set.
	 *
	 * @note The required attributes for a SedSubTask object are:
	 * @li "order"
	 * @li "task"
	 *
	 * @return a boolean value indicating whether all the required
	 * attributes for this object have been defined.
	 */
	virtual bool hasRequiredAttributes() const;


/** @cond doxygen-libsbml-internal */

	/**
	 * Subclasses should override this method to write out their contained
	 * SEDML objects as XML elements.  Be sure to call your parents
	 * implementation of this method as well.
	 */
	virtual void writeElements (XMLOutputStream& stream) const;


/** @endcond doxygen-libsbml-internal */


/** @cond doxygen-libsbml-internal */

	/**
	 * Accepts the given SedVisitor.
	 */
	virtual bool accept (SedVisitor& v) const;


/** @endcond doxygen-libsbml-internal */


/** @cond doxygen-libsbml-internal */

	/**
	 * Sets the parent SedDocument.
	 */
	virtual void setSedDocument (SedDocument* d);


/** @endcond doxygen-libsbml-internal */


protected:

/** @cond doxygen-libsbml-internal */

	/**
	 * Get the list of expected attributes for this element.
	 */
	virtual void addExpectedAttributes(ExpectedAttributes& attributes);


/** @endcond doxygen-libsbml-internal */


/** @cond doxygen-libsbml-internal */

	/**
	 * Read values from the given XMLAttributes set into their specific fields.
	 */
	virtual void readAttributes (const XMLAttributes& attributes,
	                             const ExpectedAttributes& expectedAttributes);


/** @endcond doxygen-libsbml-internal */


/** @cond doxygen-libsbml-internal */

	/**
	 * Write values of XMLAttributes to the output stream.
	 */
	virtual void writeAttributes (XMLOutputStream& stream) const;


/** @endcond doxygen-libsbml-internal */



};

class LIBSEDML_EXTERN SedListOfSubTasks : public SedListOf
{

public:

	/**
	 * Creates a new SedListOfSubTasks with the given level, version, and package version.
	 *
	 * @param level an unsigned int, the SEDML Level to assign to this SedListOfSubTasks
	 *
	 * @param version an unsigned int, the SEDML Version to assign to this SedListOfSubTasks
	 *
	 * @param pkgVersion an unsigned int, the SEDML Sed Version to assign to this SedListOfSubTasks
	 */
	SedListOfSubTasks(unsigned int level      = SEDML_DEFAULT_LEVEL,
	                  unsigned int version    = SEDML_DEFAULT_VERSION
);


	/**
	 * Creates a new SedListOfSubTasks with the given SedNamespaces object.
	 *
	 * @param sedns the SedNamespaces object
	 */
	SedListOfSubTasks(SedNamespaces* sedns);


 	/**
	 * Creates and returns a deep copy of this SedListOfSubTasks object.
	 *
	 * @return a (deep) copy of this SedListOfSubTasks object.
	 */
	virtual SedListOfSubTasks* clone () const;


 	/**
	 * Get a SubTask from the SedListOfSubTasks.
	 *
	 * @param n the index number of the SubTask to get.
	 *
	 * @return the nth SubTask in this SedListOfSubTasks.
	 *
	 * @see size()
	 */
	virtual SedSubTask* get(unsigned int n);


	/**
	 * Get a SubTask from the SedListOfSubTasks.
	 *
	 * @param n the index number of the SubTask to get.
	 *
	 * @return the nth SubTask in this SedListOfSubTasks.
	 *
	 * @see size()
	 */
	virtual const SedSubTask* get(unsigned int n) const;


	/**
	 * Get a SubTask from the SedListOfSubTasks
	 * based on its identifier.
	 *
	 * @param sid a string representing the identifier
	 * of the SubTask to get.
	 *
	 * @return SubTask in this SedListOfSubTasks
	 * with the given id or NULL if no such
	 * SubTask exists.
	 *
	 * @see get(unsigned int n)	 *
	 * @see size()
	 */
	virtual SedSubTask* get(const std::string& sid);


	/**
	 * Get a SubTask from the SedListOfSubTasks
	 * based on its identifier.
	 *
	 * @param sid a string representing the identifier
	 * of the SubTask to get.
	 *
	 * @return SubTask in this SedListOfSubTasks
	 * with the given id or NULL if no such
	 * SubTask exists.
	 *
	 * @see get(unsigned int n)	 *
	 * @see size()
	 */
	virtual const SedSubTask* get(const std::string& sid) const;


	/**
	 * Adds a copy the given "SubTask" to this SedListOfSubTasks.
	 *
	 * @param st; the SubTask object to add
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSEDML_OPERATION_SUCCESS
	 * @li LIBSEDML_INVALID_ATTRIBUTE_VALUE
	 */
	int addSubTask(const SedSubTask* st);


	/**
	 * Get the number of SubTask objects in this SedListOfSubTasks.
	 *
	 * @return the number of SubTask objects in this SedListOfSubTasks
	 */
	unsigned int getNumSubTasks() const;


	/**
	 * Creates a new SubTask object, adds it to the
	 * SedListOfSubTasks and returns the SubTask object created. 
	 *
	 * @return a new SubTask object instance
	 *
	 * @see addSubTask(const SedSubTask* st)
	 */
	SedSubTask* createSubTask();


	/**
	 * Removes the nth SubTask from this SedListOfSubTasks
	 * and returns a pointer to it.
	 *
	 * The caller owns the returned item and is responsible for deleting it.
	 *
	 * @param n the index of the SubTask to remove.
	 *
	 * @see size()
	 */
	virtual SedSubTask* remove(unsigned int n);


	/**
	 * Removes the SubTask from this SedListOfSubTasks with the given identifier
	 * and returns a pointer to it.
	 *
	 * The caller owns the returned item and is responsible for deleting it.
	 * If none of the items in this list have the identifier @p sid, then
	 * @c NULL is returned.
	 *
	 * @param sid the identifier of the SubTask to remove.
	 *
	 * @return the SubTask removed. As mentioned above, the caller owns the
	 * returned item.
	 */
	virtual SedSubTask* remove(const std::string& sid);


	/**
	 * Returns the XML element name of this object, which for SedListOfSubTasks, is
	 * always @c "sedListOfSubTasks".
	 *
	 * @return the name of this element, i.e. @c "sedListOfSubTasks".
	 */
	virtual const std::string& getElementName () const;


	/**
	 * Returns the libSEDML type code for this SEDML object.
	 * 
	 * @if clike LibSEDML attaches an identifying code to every kind of SEDML
	 * object.  These are known as <em>SEDML type codes</em>.  The set of
	 * possible type codes is defined in the enumeration #SEDMLTypeCode_t.
	 * The names of the type codes all begin with the characters @c
	 * SEDML_. @endif@if java LibSEDML attaches an identifying code to every
	 * kind of SEDML object.  These are known as <em>SEDML type codes</em>.  In
	 * other languages, the set of type codes is stored in an enumeration; in
	 * the Java language interface for libSEDML, the type codes are defined as
	 * static integer constants in the interface class {@link
	 * libsbmlConstants}.  The names of the type codes all begin with the
	 * characters @c SEDML_. @endif@if python LibSEDML attaches an identifying
	 * code to every kind of SEDML object.  These are known as <em>SEDML type
	 * codes</em>.  In the Python language interface for libSEDML, the type
	 * codes are defined as static integer constants in the interface class
	 * @link libsbml@endlink.  The names of the type codes all begin with the
	 * characters @c SEDML_. @endif@if csharp LibSEDML attaches an identifying
	 * code to every kind of SEDML object.  These are known as <em>SEDML type
	 * codes</em>.  In the C# language interface for libSEDML, the type codes
	 * are defined as static integer constants in the interface class @link
	 * libsbmlcs.libsbml@endlink.  The names of the type codes all begin with
	 * the characters @c SEDML_. @endif
	 *
	 * @return the SEDML type code for this object, or
	 * @link SEDMLTypeCode_t#SEDML_UNKNOWN SEDML_UNKNOWN@endlink (default).
	 *
	 * @see getElementName()
	 */
	virtual int getTypeCode () const;


	/**
	 * Returns the libSEDML type code for the SEDML objects
	 * contained in this SedListOf object
	 * 
	 * @if clike LibSEDML attaches an identifying code to every kind of SEDML
	 * object.  These are known as <em>SEDML type codes</em>.  The set of
	 * possible type codes is defined in the enumeration #SEDMLTypeCode_t.
	 * The names of the type codes all begin with the characters @c
	 * SEDML_. @endif@if java LibSEDML attaches an identifying code to every
	 * kind of SEDML object.  These are known as <em>SEDML type codes</em>.  In
	 * other languages, the set of type codes is stored in an enumeration; in
	 * the Java language interface for libSEDML, the type codes are defined as
	 * static integer constants in the interface class {@link
	 * libsbmlConstants}.  The names of the type codes all begin with the
	 * characters @c SEDML_. @endif@if python LibSEDML attaches an identifying
	 * code to every kind of SEDML object.  These are known as <em>SEDML type
	 * codes</em>.  In the Python language interface for libSEDML, the type
	 * codes are defined as static integer constants in the interface class
	 * @link libsbml@endlink.  The names of the type codes all begin with the
	 * characters @c SEDML_. @endif@if csharp LibSEDML attaches an identifying
	 * code to every kind of SEDML object.  These are known as <em>SEDML type
	 * codes</em>.  In the C# language interface for libSEDML, the type codes
	 * are defined as static integer constants in the interface class @link
	 * libsbmlcs.libsbml@endlink.  The names of the type codes all begin with
	 * the characters @c SEDML_. @endif
	 *
	 * @return the SEDML type code for the objects in this SedListOf instance, or
	 * @link SEDMLTypeCode_t#SEDML_UNKNOWN SEDML_UNKNOWN@endlink (default).
	 *
	 * @see getElementName()
	 */
	virtual int getItemTypeCode () const;


protected:

	/** @cond doxygen-libsbml-internal */

	/**
	 * Creates a new SubTask in this SedListOfSubTasks
	 */
	virtual SedBase* createObject(XMLInputStream& stream);


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

	/**
	 * Write the namespace for the Sed package.
	 */
	virtual void writeXMLNS(XMLOutputStream& stream) const;


	/** @endcond doxygen-libsbml-internal */



};



LIBSEDML_CPP_NAMESPACE_END

#endif  /*  __cplusplus  */

#ifndef SWIG

LIBSEDML_CPP_NAMESPACE_BEGIN
BEGIN_C_DECLS

LIBSEDML_EXTERN
SedSubTask_t *
SedSubTask_create(unsigned int level, unsigned int version);


LIBSEDML_EXTERN
void
SedSubTask_free(SedSubTask_t * sst);


LIBSEDML_EXTERN
SedSubTask_t *
SedSubTask_clone(SedSubTask_t * sst);


LIBSEDML_EXTERN
int
SedSubTask_getOrder(SedSubTask_t * sst);


LIBSEDML_EXTERN
char *
SedSubTask_getTask(SedSubTask_t * sst);


LIBSEDML_EXTERN
int
SedSubTask_isSetOrder(SedSubTask_t * sst);


LIBSEDML_EXTERN
int
SedSubTask_isSetTask(SedSubTask_t * sst);


LIBSEDML_EXTERN
int
SedSubTask_setOrder(SedSubTask_t * sst, int order);


LIBSEDML_EXTERN
int
SedSubTask_setTask(SedSubTask_t * sst, const char * task);


LIBSEDML_EXTERN
int
SedSubTask_unsetOrder(SedSubTask_t * sst);


LIBSEDML_EXTERN
int
SedSubTask_unsetTask(SedSubTask_t * sst);


LIBSEDML_EXTERN
int
SedSubTask_hasRequiredAttributes(SedSubTask_t * sst);


LIBSEDML_EXTERN
SedSubTask_t *
SedListOfSubTasks_getById(SedListOf_t * lo, const char * sid);


LIBSEDML_EXTERN
SedSubTask_t *
SedListOfSubTasks_removeById(SedListOf_t * lo, const char * sid);




END_C_DECLS
LIBSEDML_CPP_NAMESPACE_END

#endif  /*  !SWIG  */

#endif /*  SedSubTask_H__  */
