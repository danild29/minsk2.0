using Minsk.CodeAnalysis.Symbols;
using Minsk.CodeAnalysis.Syntax;
using System.Collections.Immutable;
using System.Linq;

namespace Minsk.CodeAnalysis.Binding
{
    internal class BoundObjectReferenceExpression : BoundExpression
    {
        public BoundObjectReferenceExpression(SyntaxNode syntax, BoundExpression boundName, ImmutableArray<TypedName> typedNames)
            : base(syntax)
        {
            BoundName = boundName;
            TypedNames = typedNames;
        }


        public BoundExpression BoundName { get; }

        public override TypeSymbol Type => TypedNames.Last().Type;

        public override BoundNodeKind Kind => BoundNodeKind.ObjectReferenceExpression;

        public ImmutableArray<TypedName> TypedNames { get; }
    }
}
