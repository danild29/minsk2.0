namespace Minsk.CodeAnalysis.Syntax
{
    public enum SyntaxKind
    {
        BadToken,

        // Trivia
        SkippedTextTrivia,
        LineBreakTrivia,
        WhitespaceTrivia,
        SingleLineCommentTrivia,
        MultiLineCommentTrivia,

        // Tokens
        EndOfFileToken,
        NumberToken,
        StringToken,
        PlusToken,
        PlusEqualsToken,
        MinusToken,
        MinusEqualsToken,
        StarToken,
        StarEqualsToken,
        SlashToken,
        SlashEqualsToken,
        BangToken,
        EqualsToken,
        TildeToken,
        HatToken,
        HatEqualsToken,
        AmpersandToken,
        AmpersandAmpersandToken,
        AmpersandEqualsToken,
        PipeToken,
        PipeEqualsToken,
        PipePipeToken,
        EqualsEqualsToken,
        BangEqualsToken,
        LessToken,
        LessOrEqualsToken,
        GreaterToken,
        GreaterOrEqualsToken,
        OpenParenthesisToken,
        CloseParenthesisToken,
        OpenBraceToken,
        CloseBraceToken,
        ColonToken,
        CommaToken,
        IdentifierToken,
        OpenSquareBraceToken,
        CloseSquareBraceToken,

        // Keywords
        BreakKeyword,
        ContinueKeyword,
        ElseKeyword,
        FalseKeyword,
        ForKeyword,
        FunctionKeyword,
        IfKeyword,
        LetKeyword,
        ReturnKeyword,
        ToKeyword,
        TrueKeyword,
        VarKeyword,
        WhileKeyword,
        DoKeyword,

        // Nodes
        CompilationUnit,
        FunctionDeclaration,
        GlobalStatement,
        Parameter,
        TypeClause,
        ElseClause,

        // Statements
        BlockStatement,
        VariableDeclaration,
        IfStatement,
        WhileStatement,
        DoWhileStatement,
        ForStatement,
        BreakStatement,
        ContinueStatement,
        ReturnStatement,
        ExpressionStatement,

        // Expressions
        LiteralExpression,
        NameExpression,
        UnaryExpression,
        BinaryExpression,
        CompoundAssignmentExpression,
        ParenthesizedExpression,
        AssignmentExpression,
        CallExpression,
        ArrayExpression,
        ArrayIndexExpression,
    }
}