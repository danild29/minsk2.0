using System.Collections.Generic;
using System.Collections.Immutable;

namespace Minsk.CodeAnalysis.Syntax
{

    public sealed partial class ArrayExpressionSyntax : ExpressionSyntax
    {
        public SyntaxToken OpenBraceToken { get; set; }
        public SeparatedSyntaxList<ExpressionSyntax> SyntaxNodes { get; set; }
        public SyntaxToken CloseBraceToken { get; set; }


        public ArrayExpressionSyntax(SyntaxTree syntaxTree,
                                     SyntaxToken openBraceToken,
                                     SeparatedSyntaxList<ExpressionSyntax> syntaxNodes,
                                     SyntaxToken closeBraceToken)
            : base(syntaxTree)
        {
            OpenBraceToken = openBraceToken;
            CloseBraceToken = closeBraceToken;
            SyntaxNodes = syntaxNodes;
        }

        public override SyntaxKind Kind => SyntaxKind.ArrayExpression;
    }
}