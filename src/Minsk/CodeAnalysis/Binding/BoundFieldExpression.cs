using Minsk.CodeAnalysis.Symbols;
using Minsk.CodeAnalysis.Syntax;
using System.Collections.Immutable;

namespace Minsk.CodeAnalysis.Binding
{
    internal class BoundFieldExpression : BoundExpression
    {
        public BoundFieldExpression(SyntaxNode syntax, FieldVariableSymbol variable, BoundExpression expression)
            : base(syntax)
        {
            Variable = variable;
            Expression = expression;
        }

        public FieldVariableSymbol Variable { get; }
        public BoundExpression Expression { get; }

        public override TypeSymbol Type => Expression.Type;

        public override BoundNodeKind Kind => BoundNodeKind.FieldExpression;
    }
}
