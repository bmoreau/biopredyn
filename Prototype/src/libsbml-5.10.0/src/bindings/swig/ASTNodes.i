

%{

#include <sbml/common/libsbml-config-common.h>

#ifndef LIBSBML_USE_LEGACY_MATH

#include <sbml/math/ASTTypes.h>
#include <sbml/math/ASTBase.h>
//#include <sbml/math/ASTBinaryFunctionNode.h>
//#include <sbml/math/ASTCiFunctionNode.h>
//#include <sbml/math/ASTCiNumberNode.h>
//#include <sbml/math/ASTCnBase.h>
//#include <sbml/math/ASTCnExponentialNode.h>
//#include <sbml/math/ASTCnIntegerNode.h>
//#include <sbml/math/ASTCnRationalNode.h>
//#include <sbml/math/ASTCnRealNode.h>
//#include <sbml/math/ASTConstantNumberNode.h>
//#include <sbml/math/ASTCSymbol.h>
//#include <sbml/math/ASTCSymbolAvogadroNode.h>
//#include <sbml/math/ASTCSymbolDelayNode.h>
//#include <sbml/math/ASTCSymbolTimeNode.h>
//#include <sbml/math/ASTFunction.h>
//#include <sbml/math/ASTFunctionBase.h>
//#include <sbml/math/ASTLambdaFunctionNode.h>
//#include <sbml/math/ASTNaryFunctionNode.h>
//#include <sbml/math/ASTNumber.h>
//#include <sbml/math/ASTPiecewiseFunctionNode.h>
//#include <sbml/math/ASTQualifierNode.h>
//#include <sbml/math/ASTSemanticsNode.h>
//#include <sbml/math/ASTUnaryFunctionNode.h>

#include <sbml/math/ASTNode.h>
#include <sbml/math/MathML.h>
#include <sbml/math/FormulaFormatter.h>
#include <sbml/math/FormulaParser.h>
#include <sbml/math/L3Parser.h>
#include <sbml/math/L3ParserSettings.h>

#else

#include <sbml/math-legacy/ASTNode.h>
#include <sbml/math-legacy/MathML.h>
#include <sbml/math-legacy/FormulaFormatter.h>
#include <sbml/math-legacy/FormulaParser.h>
#include <sbml/math-legacy/L3Parser.h>
#include <sbml/math-legacy/L3ParserSettings.h>

#endif


%}


#ifndef LIBSBML_USE_LEGACY_MATH

  %include <sbml/math/ASTTypes.h>
  %include <sbml/math/ASTBase.h>

  %include sbml/math/ASTNode.h
  %include sbml/math/MathML.h
  %include sbml/math/FormulaParser.h
  %include sbml/math/FormulaFormatter.h
  %include sbml/math/L3Parser.h
  %include sbml/math/L3ParserSettings.h

  %include <sbml/extension/ASTBasePlugin.h>
  
#else

  %include sbml/math-legacy/ASTNode.h
  %include sbml/math-legacy/MathML.h
  %include sbml/math-legacy/FormulaParser.h
  %include sbml/math-legacy/FormulaFormatter.h
  %include sbml/math-legacy/L3Parser.h
  %include sbml/math-legacy/L3ParserSettings.h
  
#endif
