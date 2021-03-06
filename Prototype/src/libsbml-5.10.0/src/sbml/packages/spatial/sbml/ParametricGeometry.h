/*
 * @file    ParametricGeometry.h
 * @brief   Definition of ParametricGeometry, the SBase derived class of spatial package.
 * @author  
 *
 * $Id: ParametricGeometry.h 10673 2010-01-17 07:18:20Z ajouraku $
 * $HeadURL: https://sbml.svn.sourceforge.net/svnroot/sbml/branches/libsbml-5/src/packages/spatial/sbml/ParametricGeometry.h $
 *
 *<!---------------------------------------------------------------------------
 * This file is part of libSBML.  Please visit http://sbml.org for more
 * information about SBML, and the latest version of libSBML.
 *
 * Copyright 2009 California Institute of Technology.
 * 
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation.  A copy of the license agreement is provided
 * in the file named "LICENSE.txt" included with this software distribution
 * and also available online as http://sbml.org/software/libsbml/license.html
 *------------------------------------------------------------------------- -->
 */


#ifndef ParametricGeometry_H__
#define ParametricGeometry_H__

#include <sbml/common/extern.h>
#include <sbml/common/sbmlfwd.h>
#include <sbml/packages/spatial/common/spatialfwd.h>

#ifdef __cplusplus

#include <string>

#include <sbml/SBase.h>
#include <sbml/ListOf.h>
#include <sbml/packages/spatial/extension/SpatialExtension.h>
#include <sbml/packages/spatial/sbml/GeometryDefinition.h>
#include <sbml/packages/spatial/sbml/ParametricObject.h>
#include <sbml/packages/spatial/sbml/SpatialPoint.h>


LIBSBML_CPP_NAMESPACE_BEGIN


class LIBSBML_EXTERN ParametricGeometry : public GeometryDefinition
{
protected:

  ListOfParametricObjects	mParametricObjects;
  ListOfSpatialPoints		mSpatialPoints;

public:

  /**
   * Creates a new ParametricGeometry with the given level, version, and package version.
   */
   ParametricGeometry(unsigned int level      = SpatialExtension::getDefaultLevel(),
          unsigned int version    = SpatialExtension::getDefaultVersion(),
          unsigned int pkgVersion = SpatialExtension::getDefaultPackageVersion());


  /**
   * Creates a new ParametricGeometry with the given SpatialPkgNamespaces object.
   */
   ParametricGeometry(SpatialPkgNamespaces* spatialns);


  /**
   * Copy constructor.
   */
   ParametricGeometry(const ParametricGeometry& source);


  /**
   * Assignment operator.
   */
   ParametricGeometry& operator=(const ParametricGeometry& source);


  /**
   * Destructor.
   */ 
  virtual ~ParametricGeometry ();

  /**
   * Adds a copy of the given ParametricObject object to this ParametricGeometry.
   *
   * @param d the ParametricObject to add
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li LIBSBML_OPERATION_SUCCESS
   * @li LIBSBML_LEVEL_MISMATCH
   * @li LIBSBML_VERSION_MISMATCH
   * @li LIBSBML_DUPLICATE_OBJECT_ID
   * @li LIBSBML_OPERATION_FAILED
   * 
   * @note This method should be used with some caution.  The fact that
   * this method @em copies the object passed to it means that the caller
   * will be left holding a physically different object instance than the
   * one contained in this ParametricGeometry.  Changes made to the original object
   * instance (such as resetting attribute values) will <em>not affect the
   * instance in the ParametricGeometry</em>.  In addition, the caller should make sure
   * to free the original object if it is no longer being used, or else a
   * memory leak will result.  Please see ParametricGeometry::createParametricObject()
   * for a method that does not lead to these issues.
   *
   * @see createParametricObject()
   */
  int addParametricObject (const ParametricObject* po);

  /**
   * Adds a copy of the given SpatialPoint object to this ParametricGeometry.
   *
   * @param d the SpatialPoint to add
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li LIBSBML_OPERATION_SUCCESS
   * @li LIBSBML_LEVEL_MISMATCH
   * @li LIBSBML_VERSION_MISMATCH
   * @li LIBSBML_DUPLICATE_OBJECT_ID
   * @li LIBSBML_OPERATION_FAILED
   * 
   * @note This method should be used with some caution.  The fact that
   * this method @em copies the object passed to it means that the caller
   * will be left holding a physically different object instance than the
   * one contained in this ParametricGeometry.  Changes made to the original object
   * instance (such as resetting attribute values) will <em>not affect the
   * instance in the ParametricGeometry</em>.  In addition, the caller should make sure
   * to free the original object if it is no longer being used, or else a
   * memory leak will result.  Please see ParametricGeometry::createSpatialPoint()
   * for a method that does not lead to these issues.
   *
   * @see createSpatialPoint()
   */
  int addSpatialPoint (const SpatialPoint* sp);


  /**
   * Creates a new ParametricObject object inside this ParametricGeometry and returns it.
   *
   * @return the ParametricObject object created
   *
   * @see addParametricObject(const ParametricObject* d)
   */
  ParametricObject* createParametricObject ();

  /**
   * Creates a new SpatialPoint object inside this ParametricGeometry and returns it.
   *
   * @return the SpatialPoint object created
   *
   * @see addSpatialPoint(const SpatialPoint* d)
   */
  SpatialPoint* createSpatialPoint ();

  /**
   * Get the ListOfParametricObjects object in this ParametricGeometry.
   * 
   * @return the list of ParametricObject for this ParametricGeometry.
   */
  const ListOfParametricObjects* getListOfParametricObjects () const;


  /**
   * Get the ListOfParametricObjects object in this ParametricGeometry.
   * 
   * @return the list of ParametricObject for this ParametricGeometry.
   */
  ListOfParametricObjects* getListOfParametricObjects ();

  /**
   * Get the ListOfSpatialPoints object in this ParametricGeometry.
   * 
   * @return the list of SpatialPoints for this ParametricGeometry.
   */
  const ListOfSpatialPoints* getListOfSpatialPoints () const;


  /**
   * Get the ListOfSpatialPoints object in this ParametricGeometry.
   * 
   * @return the list of SpatialPoints for this ParametricGeometry.
   */
  ListOfSpatialPoints* getListOfSpatialPoints ();


  /**
   * Get the nth ParametricObject object in this ParametricGeometry.
   * 
   * @return the nth ParametricObject of this ParametricGeometry.
   */
  const ParametricObject* getParametricObject (unsigned int n) const;


  /**
   * Get the nth ParametricObject object in this ParametricGeometry.
   * 
   * @return the nth ParametricObject of this ParametricGeometry.
   */
  ParametricObject* getParametricObject (unsigned int n);


  /**
   * Get a ParametricObject object based on its identifier.
   * 
   * @return the ParametricObject in this ParametricGeometry with the identifier
   * @p sid or NULL if no such ParametricObject exists.
   */
  const ParametricObject* getParametricObject (const std::string& sid) const;


  /**
   * Get a ParametricObject object based on its identifier.
   * 
   * @return the ParametricObject in this ParametricGeometry with the identifier
   * @p sid or NULL if no such ParametricObject exists.
   */
  ParametricObject* getParametricObject (const std::string& sid);

  /**
   * Get the nth SpatialPoint object in this ParametricGeometry.
   * 
   * @return the nth SpatialPoint of this ParametricGeometry.
   */
  const SpatialPoint* getSpatialPoint (unsigned int n) const;


  /**
   * Get the nth SpatialPoint object in this ParametricGeometry.
   * 
   * @return the nth SpatialPoint of this ParametricGeometry.
   */
  SpatialPoint* getSpatialPoint (unsigned int n);


  /**
   * Get a SpatialPoint object based on its identifier.
   * 
   * @return the SpatialPoint in this ParametricGeometry with the identifier
   * @p sid or NULL if no such SpatialPoint exists.
   */
  const SpatialPoint* getSpatialPoint (const std::string& sid) const;


  /**
   * Get a SpatialPoint object based on its identifier.
   * 
   * @return the SpatialPoint in this ParametricGeometry with the identifier
   * @p sid or NULL if no such SpatialPoint exists.
   */
  SpatialPoint* getSpatialPoint (const std::string& sid);


  /**
   * Get the number of ParametricObject objects in this ParametricGeometry.
   * 
   * @return the number of ParametricObject in this ParametricGeometry.
   */
  unsigned int getNumParametricObjects () const;

  /**
   * Get the number of SpatialPoint objects in this ParametricGeometry.
   * 
   * @return the number of SpatialPoint in this ParametricGeometry.
   */
  unsigned int getNumSpatialPoints () const;


 /**
   * Removes the nth ParametricObject object from this ParametricGeometry object and 
   * returns a pointer to it.
   *
   * The caller owns the returned object and is responsible for deleting it.
   *
   * @param n the index of the ParametricObject object to remove
   *
   * @return the ParametricObject object removed.  As mentioned above, 
   * the caller owns the returned item. NULL is returned if the given index 
   * is out of range.
   *
   */
  ParametricObject* removeParametricObject (unsigned int n);


  /**
   * Removes the ParametricObject object with the given identifier from this ParametricGeometry 
   * object and returns a pointer to it.
   *
   * The caller owns the returned object and is responsible for deleting it.
   * If none of the ParametricObject objects in this ParametricGeometry object have the identifier 
   * @p sid, then @c NULL is returned.
   *
   * @param sid the identifier of the ParametricObject object to remove
   *
   * @return the ParametricObject object removed.  As mentioned above, the 
   * caller owns the returned object. NULL is returned if no ParametricObject
   * object with the identifier exists in this ParametricGeometry object.
   */
  ParametricObject* removeParametricObject (const std::string& sid);

 /**
   * Removes the nth SpatialPoint object from this ParametricGeometry object and 
   * returns a pointer to it.
   *
   * The caller owns the returned object and is responsible for deleting it.
   *
   * @param n the index of the SpatialPoint object to remove
   *
   * @return the SpatialPoint object removed.  As mentioned above, 
   * the caller owns the returned item. NULL is returned if the given index 
   * is out of range.
   *
   */
  SpatialPoint* removeSpatialPoint (unsigned int n);


  /**
   * Removes the SpatialPoint object with the given identifier from this ParametricGeometry 
   * object and returns a pointer to it.
   *
   * The caller owns the returned object and is responsible for deleting it.
   * If none of the SpatialPoint objects in this ParametricGeometry object have the identifier 
   * @p sid, then @c NULL is returned.
   *
   * @param sid the identifier of the SpatialPoint object to remove
   *
   * @return the SpatialPoint object removed.  As mentioned above, the 
   * caller owns the returned object. NULL is returned if no SpatialPoint
   * object with the identifier exists in this ParametricGeometry object.
   */
  SpatialPoint* removeSpatialPoint (const std::string& sid);

  /**
   * Subclasses should override this method to return XML element name of
   * this SBML object.
   *
   * @return the string of the name of this element.

  virtual const std::string& getElementName () const ;
   */

  /**
   * @return a (deep) copy of this ParametricGeometry.
   */
  virtual ParametricGeometry* clone () const;

  /**
   * @return the typecode (int) of this SBML object or SBML_UNKNOWN
   * (default).
   *
   * @see getElementName()
   
  int getTypeCode () const;
*/

  /** @cond doxygenLibsbmlInternal */
  /**
   * Subclasses should override this method to write out their contained
   * SBML objects as XML elements.  Be sure to call your parents
   * implementation of this method as well.  For example:
   *
   *   SBase::writeElements(stream);
   *   mReactans.write(stream);
   *   mProducts.write(stream);
   *   ...
   */
  void writeElements (XMLOutputStream& stream) const;
 

  /**
   * Accepts the given SBMLVisitor.
   *
   * @return the result of calling <code>v.visit()</code>, which indicates
   * whether or not the Visitor would like to visit the SBML object's next
   * sibling object (if available).
   */
  virtual bool accept (SBMLVisitor& v) const;
  /** @endcond doxygenLibsbmlInternal */
    

   /** @cond doxygenLibsbmlInternal */
  /**
   * Sets the parent SBMLDocument of this SBML object.
   *
   * @param d the SBMLDocument object to use
   */
  virtual void setSBMLDocument (SBMLDocument* d);

  /**
   * Sets this SBML object to child SBML objects (if any).
   * (Creates a child-parent relationship by the parent)
   *
   * Subclasses must override this function if they define
   * one ore more child elements.
   * Basically, this function needs to be called in
   * constructor, copy constructor, assignment operator.
   *
   * @see setSBMLDocument
   * @see enablePackageInternal
   */
  void connectToChild ();

  /**
   * Enables/Disables the given package with this element and child
   * elements (if any).
   * (This is an internal implementation for enablePakcage function)
   *
   * @note Subclasses in which one or more child elements are defined
   * must override this function.
   */
  virtual void enablePackageInternal(const std::string& pkgURI,
                                     const std::string& pkgPrefix, bool flag);
  /** @endcond doxygenLibsbmlInternal */


protected:
  /**
   * @return the SBML object corresponding to next XMLToken in the
   * XMLInputStream or NULL if the token was not recognized.
   */
  SBase*
  createObject (XMLInputStream& stream);

  /**
   * Subclasses should override this method to get the list of
   * expected attributes.
   * This function is invoked from corresponding readAttributes()
   * function.
   */
  void addExpectedAttributes(ExpectedAttributes& attributes){
  };


  /**
   * Subclasses should override this method to read values from the given
   * XMLAttributes set into their specific fields.  Be sure to call your
   * parents implementation of this method as well.
   */
  void readAttributes (const XMLAttributes& attributes, 
                               const ExpectedAttributes& expectedAttributes);


  /**
   * Subclasses should override this method to write their XML attributes
   * to the XMLOutputStream.  Be sure to call your parents implementation
   * of this method as well.  For example:
   *
   *   SBase::writeAttributes(stream);
   *   stream.writeAttribute( "id"  , mId   );
   *   stream.writeAttribute( "name", mName );
   *   ...
   */
  virtual void writeAttributes (XMLOutputStream& stream) const;

  /* the validator classes need to be friends to access the 
   * protected constructor that takes no arguments
   */
  friend class Validator;
  friend class ConsistencyValidator;
  friend class IdentifierConsistencyValidator;
  friend class InternalConsistencyValidator;
/*  
  friend class L1CompatibilityValidator;
  friend class L2v1CompatibilityValidator;
  friend class L2v2CompatibilityValidator;
  friend class L2v3CompatibilityValidator;
  friend class L2v4CompatibilityValidator;
  friend class MathMLConsistencyValidator;
  friend class SBOConsistencyValidator;
  friend class UnitConsistencyValidator;
*/
  friend class ModelingPracticeValidator;
  friend class OverdeterminedValidator;

  /** @endcond doxygenLibsbmlInternal */


};


#ifndef SWIG
/*template<>
struct IdEq<ParametricGeometry> : public std::unary_function<SBase*, bool>
{
  const std::string& coordSystem;

  IdEq (const std::string& coordSystem) : id(coordSystem) { }
  bool operator() (SBase* sb) 
       { return static_cast <ParametricGeometry*> (sb)->getSpatialId() == coordSystem; }
};
*/
#endif
/** @endcond doxygenLibsbmlInternal */

LIBSBML_CPP_NAMESPACE_END

#endif /* __cplusplus */


#ifndef SWIG

LIBSBML_CPP_NAMESPACE_BEGIN
BEGIN_C_DECLS

//
// C API will be added here.
//


LIBSBML_EXTERN
int
ParametricGeometry_addParametricObject (ParametricGeometry_t *pg, const ParametricObject_t *po);

LIBSBML_EXTERN
int
ParametricGeometry_addSpatialPoint (ParametricGeometry_t *pg, const SpatialPoint_t *sp);


LIBSBML_EXTERN
ParametricObject_t *
ParametricGeometry_createParametricObject (ParametricGeometry_t *pg);


LIBSBML_EXTERN
SpatialPoint_t *
ParametricGeometry_createSpatialPoint (ParametricGeometry_t *pg);


LIBSBML_EXTERN
ListOf_t *
ParametricGeometry_getListOfParametricObjects (ParametricGeometry_t *pg);


LIBSBML_EXTERN
ListOf_t *
ParametricGeometry_getListOfSpatialPoints (ParametricGeometry_t *pg);


LIBSBML_EXTERN
ParametricGeometry_t *
ParametricGeometry_clone (const ParametricGeometry_t *pg);


LIBSBML_EXTERN
ParametricObject_t *
ParametricGeometry_getParametricObject (ParametricGeometry_t *pg, unsigned int n);


LIBSBML_EXTERN
ParametricObject_t *
ParametricGeometry_getParametricObjectById (ParametricGeometry_t *pg, const char *sid);


LIBSBML_EXTERN
SpatialPoint_t *
ParametricGeometry_getSpatialPoint (ParametricGeometry_t *pg, unsigned int n);


LIBSBML_EXTERN
SpatialPoint_t *
ParametricGeometry_getSpatialPointById (ParametricGeometry_t *pg, const char *sid);


LIBSBML_EXTERN
unsigned int
ParametricGeometry_getNumParametricObjects (const ParametricGeometry_t *pg);


LIBSBML_EXTERN
unsigned int
ParametricGeometry_getNumSpatialPoints (const ParametricGeometry_t *pg);


LIBSBML_EXTERN
ParametricObject_t*
ParametricGeometry_removeParametricObject (ParametricGeometry_t *pg, unsigned int n);


LIBSBML_EXTERN
ParametricObject_t*
ParametricGeometry_removeParametricObjectById (ParametricGeometry_t *pg, const char* sid);


LIBSBML_EXTERN
SpatialPoint_t*
ParametricGeometry_removeSpatialPoint (ParametricGeometry_t *pg, unsigned int n);


LIBSBML_EXTERN
SpatialPoint_t*
ParametricGeometry_removeSpatialPointById (ParametricGeometry_t *pg, const char* sid);


END_C_DECLS
LIBSBML_CPP_NAMESPACE_END


#endif  /* !SWIG */
#endif  /* ParametricGeometry_H__ */
