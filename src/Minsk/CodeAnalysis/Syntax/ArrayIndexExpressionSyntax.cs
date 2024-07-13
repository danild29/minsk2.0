namespace Minsk.CodeAnalysis.Syntax
{
    internal sealed partial class ArrayIndexExpressionSyntax : ExpressionSyntax
    {
        public ArrayIndexExpressionSyntax(SyntaxTree syntaxTree, ExpressionSyntax nameExpression, SyntaxToken openBraceToken, ExpressionSyntax expression, SyntaxToken closeBraceToken)
            : base(syntaxTree)
        {
            NameExpression = nameExpression;
            OpenBraceToken = openBraceToken;
            Expression = expression;
            CloseBraceToken = closeBraceToken;
        }

        public ExpressionSyntax NameExpression { get; }
        public SyntaxToken OpenBraceToken { get; }
        public ExpressionSyntax Expression { get; }
        public SyntaxToken CloseBraceToken { get; }

        public override SyntaxKind Kind => SyntaxKind.ArrayIndexExpression;
    }
}