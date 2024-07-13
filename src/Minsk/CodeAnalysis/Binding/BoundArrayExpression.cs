using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Minsk.CodeAnalysis.Symbols;
using Minsk.CodeAnalysis.Syntax;

namespace Minsk.CodeAnalysis.Binding
{
    internal class BoundArrayExpression : BoundExpression
    {
        public BoundArrayExpression(SyntaxNode syntax, ImmutableArray<BoundExpression> boundItems)
            : base(syntax)
        {
            BoundItems = boundItems;
        }

        public override BoundNodeKind Kind => BoundNodeKind.ArrayExpression;
        public override TypeSymbol Type => TypeSymbol.Array;
        public ImmutableArray<BoundExpression> BoundItems { get; }
    }
}
