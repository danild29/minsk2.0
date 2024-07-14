namespace Minsk.CodeAnalysis.Syntax
{
    internal sealed partial class ObjectReferenceExpressionSyntax : ExpressionSyntax
    {

        public ObjectReferenceExpressionSyntax(SyntaxTree syntaxTree, ExpressionSyntax nameExpression, SyntaxToken dotToken, SyntaxToken identifier)
            : base(syntaxTree)
        {
            NameExpression = nameExpression;
            DotToken = dotToken;
            Identifier = identifier;
        }

        public ExpressionSyntax NameExpression { get; }
        public SyntaxToken DotToken { get; }
        public SyntaxToken Identifier { get; }

        public override SyntaxKind Kind => SyntaxKind.ObjectReferenceExpression;
    }
}