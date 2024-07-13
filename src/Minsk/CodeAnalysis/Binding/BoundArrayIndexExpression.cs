using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Minsk.CodeAnalysis.Symbols;
using Minsk.CodeAnalysis.Syntax;

namespace Minsk.CodeAnalysis.Binding
{
    internal class BoundArrayIndexExpression : BoundExpression
    {
        public BoundArrayIndexExpression(SyntaxNode syntax, BoundExpression variable, BoundExpression expression)
            : base(syntax)
        {
            Variable = variable;
            Expression = expression;
        }

        public BoundExpression Variable { get; }
        public BoundExpression Expression { get; }

        public override TypeSymbol Type => TypeSymbol.Any;

        public override BoundNodeKind Kind => BoundNodeKind.ArrayIndexExpression;
    }
}
