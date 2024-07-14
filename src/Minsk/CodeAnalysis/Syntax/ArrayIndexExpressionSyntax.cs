using System.Collections.Generic;

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

    public sealed partial class FieldExpressionSyntax : ExpressionSyntax
    {
        public FieldExpressionSyntax(SyntaxTree syntaxTree, SyntaxToken identifier, TypeClauseSyntax? typeClause, SyntaxToken equalsToken, ExpressionSyntax initializer)
            :base(syntaxTree)
        {
            Identifier = identifier;
            TypeClause = typeClause;
            EqualsToken = equalsToken;
            Initializer = initializer;
        }

        public SyntaxToken Identifier { get; }
        public TypeClauseSyntax? TypeClause { get; }
        public SyntaxToken EqualsToken { get; }
        public ExpressionSyntax Initializer { get; }

        public override SyntaxKind Kind => SyntaxKind.FieldExpression;
    }


    public sealed partial class ObjectExpressionSyntax :ExpressionSyntax
    {
        public ObjectExpressionSyntax(SyntaxTree syntaxTree, SyntaxToken openBrace, SeparatedSyntaxList<FieldExpressionSyntax> fields, SyntaxToken closeBrace)
            : base(syntaxTree)
        {
            OpenBrace = openBrace;
            Fields = fields;
            CloseBrace = closeBrace;
        }

        public SyntaxToken OpenBrace { get; }
        public SeparatedSyntaxList<FieldExpressionSyntax> Fields { get; }
        public SyntaxToken CloseBrace { get; }

        public override SyntaxKind Kind => SyntaxKind.ObjectExpression;
    }
}