using Minsk.CodeAnalysis.Symbols;
using Minsk.CodeAnalysis.Syntax;
using System.Collections.Immutable;

namespace Minsk.CodeAnalysis.Binding
{
    internal class BoundObjectExpression : BoundExpression
    {
        public BoundObjectExpression(SyntaxNode syntax, ImmutableArray<BoundFieldExpression> boundExpressions)
            : base(syntax)
        {
            BoundExpressions = boundExpressions;
        }

        public ImmutableArray<BoundFieldExpression> BoundExpressions { get; }

        public override TypeSymbol Type => TypeSymbol.Any;

        public override BoundNodeKind Kind => BoundNodeKind.ObjectExpression;
    }
}
