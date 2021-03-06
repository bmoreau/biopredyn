/**
* Begin svn Header
* $Rev: 32 $:	Revision of last commit
* $Author: josephodada@gmail.com $:	Author of last commit
* $Date: 2013-04-25 12:32:42 +0200 (Thu, 25 Apr 2013) $:	Date of last commit
* $HeadURL: http://numl.googlecode.com/svn/trunk/libnuml/src/numl/NUMLVisitor.h $
* $Id: NUMLVisitor.h 32 2013-04-25 10:32:42Z josephodada@gmail.com $
* End svn Header
* ****************************************************************************
* This file is part of libNUML.  Please visit http://code.google.com/p/numl/for more
* information about NUML, and the latest version of libNUML.
* Copyright (c) 2013 The University of Manchester.
*
* This library is free software; you can redistribute it and/or modify it
* under the terms of the GNU Lesser General Public License as published
* by the Free Software Foundation.  A copy of the license agreement is
* provided in the file named "LICENSE.txt" included with this software
* distribution and also available online as http://www.gnu.org/licenses/lgpl.html
*
* Contributors:
* Joseph O. Dada, The University of Manchester - initial API and implementation
* ****************************************************************************
**/

#ifndef NUMLVisitor_h
#define NUMLVisitor_h


#ifdef __cplusplus


#include <numl/NUMLTypeCodes.h>

LIBNUML_CPP_NAMESPACE_BEGIN

/**
 * Forward class name declarations avoid cyclic dependencies.
 */

class NMBase;

class NUMLDocument;
class OntologyTerm;
//class Result;
class ResultComponent;
class Dimension;
class CompositeValue;
class Tuple;
class AtomicValue;
class DimensionDescription;
class CompositeDescription;
class TupleDescription;
class AtomicDescription;

class Constraint;


class NUMLList;


/**
 * Implementation of the Visitor design pattern, for operations on NUML objects
 *
 * The Visitor Pattern (Design Patterns, Gamma et al.\ ) allows you to add
 * operations to an established class hierarchy without actually modifying
 * the classes in heirarchy.  For computer science types, C++
 * implementations of Visitor are a form of double-dispatch.
 *
 * For convenience, an NUMLVisitor couples the notion of visitation with
 * NUML object tree traversal.
 */
class NUMLVisitor
{
public:

  virtual ~NUMLVisitor ();

  virtual void visit (const NUMLDocument &x);
  virtual void visit (const NUMLList  &x, NUMLTypeCode_t type);

  virtual bool visit (const NMBase                  &x);
  virtual bool visit (const OntologyTerm     	  &x);

 // virtual bool visit (const Result                  &x);
  virtual bool visit (const ResultComponent     	  &x);
  virtual bool visit (const Dimension	           &x);
  virtual bool visit (const CompositeValue	           &x);
  virtual bool visit (const AtomicValue	           &x);
  virtual bool visit (const Tuple	           &x);
  virtual bool visit (const DimensionDescription	           &x);
  virtual bool visit (const CompositeDescription	           &x);
   virtual bool visit (const AtomicDescription	           &x);
   virtual bool visit (const TupleDescription	           &x);


  virtual void leave (const NUMLDocument &x);
  virtual void leave (const OntologyTerm        &x);

  virtual void leave (const Tuple	           &x);
//  virtual void leave (const Result                  &x);
  virtual void leave (const ResultComponent     	  &x);
  virtual void leave (const Dimension	           &x);
  virtual void leave (const DimensionDescription	           &x);
  virtual void leave (const CompositeValue	           &x);
  virtual void leave (const AtomicValue	           &x);
  virtual void leave (const CompositeDescription       &x);
  virtual void leave (const TupleDescription          &x);
  virtual void leave (const AtomicDescription          &x);

  virtual void leave (const NUMLList &x, NUMLTypeCode_t type);
};

LIBNUML_CPP_NAMESPACE_END

#endif  /* __cplusplus */
#endif  /* NUMLVisitor_h */
