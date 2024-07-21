using System.Collections.Immutable;

namespace Minsk.CodeAnalysis.Syntax
{
    internal sealed partial class ObjectReferenceExpressionSyntax : ExpressionSyntax
    {

        public ObjectReferenceExpressionSyntax(SyntaxTree syntaxTree, NameExpressionSyntax nameExpression, ImmutableArray<SyntaxToken> nodes)
            : base(syntaxTree)
        {
            NameExpression = nameExpression;
            Nodes = nodes;
        }

        public NameExpressionSyntax NameExpression { get; }
        public ImmutableArray<SyntaxToken> Nodes { get; }

        public override SyntaxKind Kind => SyntaxKind.ObjectReferenceExpression;
    }
}