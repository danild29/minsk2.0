using Minsk.CodeAnalysis.Symbols;
using Minsk.CodeAnalysis.Syntax;
using System.Collections.Immutable;

namespace Minsk.CodeAnalysis.Binding
{
    internal class BoundObjectExpression : BoundExpression
    {
        public BoundObjectExpression(SyntaxNode syntax, ImmutableArray<BoundFieldExpression> boundExpressions, TypeSymbol type)
            : base(syntax)
        {
            BoundExpressions = boundExpressions;
            Type = type;
        }

        public ImmutableArray<BoundFieldExpression> BoundExpressions { get; }

        public override TypeSymbol Type { get;  }

        public override BoundNodeKind Kind => BoundNodeKind.ObjectExpression;
    }
}
