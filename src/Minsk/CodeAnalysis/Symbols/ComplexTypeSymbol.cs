using System.Collections.Generic;
using System.Linq;

namespace Minsk.CodeAnalysis.Symbols
{
    public sealed class ComplexTypeSymbol : TypeSymbol
    {
        internal ComplexTypeSymbol(string name, IEnumerable<TypedName> declarationSyntax)
            : base(name)
        {
            DeclarationSyntax = declarationSyntax;
        }

        internal IEnumerable<TypedName> GetField(string name) => DeclarationSyntax.Where(x => x.Name.Text == name);

        internal IEnumerable<string> Fields => DeclarationSyntax.Select(x => x.Name.Text);

        internal IEnumerable<TypedName> DeclarationSyntax { get; }
    }
}