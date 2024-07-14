using Minsk.CodeAnalysis.Binding;

namespace Minsk.CodeAnalysis.Symbols
{
    public class LocalVariableSymbol : VariableSymbol
    {
        internal LocalVariableSymbol(string name, bool isReadOnly, TypeSymbol type, BoundConstant? constant)
            : base(name, isReadOnly, type, constant)
        {
        }

        public override SymbolKind Kind => SymbolKind.LocalVariable;
    }

    public class FieldVariableSymbol : VariableSymbol
    {
        internal FieldVariableSymbol(string name, TypeSymbol type, BoundConstant? constant)
            : base(name, true, type, constant)
        {
        }

        public override SymbolKind Kind => SymbolKind.FieldVariable;
    }

}