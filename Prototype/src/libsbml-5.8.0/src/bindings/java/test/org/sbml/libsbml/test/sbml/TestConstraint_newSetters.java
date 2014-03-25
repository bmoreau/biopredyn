/*
 * @file    TestConstraint_newSetters.java
 * @brief   Constraint unit tests for new set function API
 *
 * @author  Akiya Jouraku (Java conversion)
 * @author  Sarah Keating 
 * 
 * ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
 *
 * DO NOT EDIT THIS FILE.
 *
 * This file was generated automatically by converting the file located at
 * src/sbml/test/TestConstraint_newSetters.c
 * using the conversion program dev/utilities/translateTests/translateTests.pl.
 * Any changes made here will be lost the next time the file is regenerated.
 *
 * -----------------------------------------------------------------------------
 * This file is part of libSBML.  Please visit http://sbml.org for more
 * information about SBML, and the latest version of libSBML.
 *
 * Copyright 2005-2010 California Institute of Technology.
 * Copyright 2002-2005 California Institute of Technology and
 *                     Japan Science and Technology Corporation.
 * 
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation.  A copy of the license agreement is provided
 * in the file named "LICENSE.txt" included with this software distribution
 * and also available online as http://sbml.org/software/libsbml/license.html
 * -----------------------------------------------------------------------------
 */

package org.sbml.libsbml.test.sbml;

import org.sbml.libsbml.*;

import java.io.File;
import java.lang.AssertionError;

public class TestConstraint_newSetters {

  static void assertTrue(boolean condition) throws AssertionError
  {
    if (condition == true)
    {
      return;
    }
    throw new AssertionError();
  }

  static void assertEquals(Object a, Object b) throws AssertionError
  {
    if ( (a == null) && (b == null) )
    {
      return;
    }
    else if ( (a == null) || (b == null) )
    {
      throw new AssertionError();
    }
    else if (a.equals(b))
    {
      return;
    }

    throw new AssertionError();
  }

  static void assertNotEquals(Object a, Object b) throws AssertionError
  {
    if ( (a == null) && (b == null) )
    {
      throw new AssertionError();
    }
    else if ( (a == null) || (b == null) )
    {
      return;
    }
    else if (a.equals(b))
    {
      throw new AssertionError();
    }
  }

  static void assertEquals(boolean a, boolean b) throws AssertionError
  {
    if ( a == b )
    {
      return;
    }
    throw new AssertionError();
  }

  static void assertNotEquals(boolean a, boolean b) throws AssertionError
  {
    if ( a != b )
    {
      return;
    }
    throw new AssertionError();
  }

  static void assertEquals(int a, int b) throws AssertionError
  {
    if ( a == b )
    {
      return;
    }
    throw new AssertionError();
  }

  static void assertNotEquals(int a, int b) throws AssertionError
  {
    if ( a != b )
    {
      return;
    }
    throw new AssertionError();
  }
  private Constraint C;

  protected void setUp() throws Exception
  {
    C = new  Constraint(2,4);
    if (C == null);
    {
    }
  }

  protected void tearDown() throws Exception
  {
    C = null;
  }

  public void test_Constraint_setMath1()
  {
    ASTNode math = libsbml.parseFormula("2 * k");
    int i = C.setMath(math);
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertTrue( !C.getMath().equals(math) );
    assertEquals( true, C.isSetMath() );
    i = C.setMath(null);
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertTrue( C.getMath() == null );
    assertEquals( false, C.isSetMath() );
    math = null;
  }

  public void test_Constraint_setMath2()
  {
    ASTNode math = new  ASTNode(libsbml.AST_DIVIDE);
    int i = C.setMath(math);
    assertTrue( i == libsbml.LIBSBML_INVALID_OBJECT );
    assertEquals( false, C.isSetMath() );
    math = null;
  }

  public void test_Constraint_setMessage1()
  {
    XMLNode node = new XMLNode();
    int i = C.setMessage(node);
    assertTrue( i == libsbml.LIBSBML_INVALID_OBJECT );
    assertTrue( C.isSetMessage() == false );
    i = C.unsetMessage();
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertEquals( false, C.isSetMessage() );
    if (C.getMessage() != null);
    {
    }
    node = null;
  }

  public void test_Constraint_setMessage2()
  {
    XMLNode text = XMLNode.convertStringToXMLNode(" Some text ",null);
    XMLTriple triple = new  XMLTriple("p", "http://www.w3.org/1999/xhtml", "");
    XMLAttributes att = new  XMLAttributes();
    XMLNamespaces xmlns = new  XMLNamespaces();
    xmlns.add( "http://www.w3.org/1999/xhtml", "");
    XMLNode p = new XMLNode(triple,att,xmlns);
    p.addChild(text);
    XMLTriple triple1 = new  XMLTriple("message", "", "");
    XMLAttributes att1 = new  XMLAttributes();
    XMLNode node = new XMLNode(triple1,att1);
    node.addChild(p);
    int i = C.setMessage(node);
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertTrue( C.isSetMessage() == true );
    i = C.unsetMessage();
    assertTrue( i == libsbml.LIBSBML_OPERATION_SUCCESS );
    assertEquals( false, C.isSetMessage() );
    if (C.getMessage() != null);
    {
    }
    node = null;
  }

  /**
   * Loads the SWIG-generated libSBML Java module when this class is
   * loaded, or reports a sensible diagnostic message about why it failed.
   */
  static
  {
    String varname;
    String shlibname;

    if (System.getProperty("mrj.version") != null)
    {
      varname = "DYLD_LIBRARY_PATH";    // We're on a Mac.
      shlibname = "libsbmlj.jnilib and/or libsbml.dylib";
    }
    else
    {
      varname = "LD_LIBRARY_PATH";      // We're not on a Mac.
      shlibname = "libsbmlj.so and/or libsbml.so";
    }

    try
    {
      System.loadLibrary("sbmlj");
      // For extra safety, check that the jar file is in the classpath.
      Class.forName("org.sbml.libsbml.libsbml");
    }
    catch (SecurityException e)
    {
      e.printStackTrace();
      System.err.println("Could not load the libSBML library files due to a"+
                         " security exception.\n");
      System.exit(1);
    }
    catch (UnsatisfiedLinkError e)
    {
      e.printStackTrace();
      System.err.println("Error: could not link with the libSBML library files."+
                         " It is likely\nyour " + varname +
                         " environment variable does not include the directories\n"+
                         "containing the " + shlibname + " library files.\n");
      System.exit(1);
    }
    catch (ClassNotFoundException e)
    {
      e.printStackTrace();
      System.err.println("Error: unable to load the file libsbmlj.jar."+
                         " It is likely\nyour -classpath option and CLASSPATH" +
                         " environment variable\n"+
                         "do not include the path to libsbmlj.jar.\n");
      System.exit(1);
    }
  }
}
