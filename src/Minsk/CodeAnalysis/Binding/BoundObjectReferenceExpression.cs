using Minsk.CodeAnalysis.Symbols;
using Minsk.CodeAnalysis.Syntax;
using System.Collections.Immutable;

namespace Minsk.CodeAnalysis.Binding
{
    internal class BoundObjectReferenceExpression : BoundExpression
    {
        public BoundObjectReferenceExpression(SyntaxNode syntax, BoundExpression boundName, SyntaxToken field)
            : base(syntax)
        {
            BoundName = boundName;
            Field = field;
        }

        public BoundExpression BoundName { get; }
        public SyntaxToken Field { get; }

        public override TypeSymbol Type => TypeSymbol.Any;

        public override BoundNodeKind Kind => BoundNodeKind.ObjectReferenceExpression;
    }
}
