using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Threading;
using Minsk.CodeAnalysis.Binding;
using Minsk.CodeAnalysis.Emit;
using Minsk.CodeAnalysis.Symbols;
using Minsk.CodeAnalysis.Syntax;

namespace Minsk.CodeAnalysis
{
    public class TypeManager
    {
        public static Dictionary<string, ComplexTypeSymbol> Types = new Dictionary<string, ComplexTypeSymbol>();

        internal static ComplexTypeSymbol Create(IEnumerable<TypedName> declarationSyntax)
        {
            var name = string.Join("", declarationSyntax.Select(x => x.Name.Text + x.Type.Name));
            return Create(declarationSyntax, name);
        }

        internal static ComplexTypeSymbol Create(IEnumerable<TypedName> declarationSyntax, string name)
        {
            var complexType = new ComplexTypeSymbol(name, declarationSyntax);

            if (Types.ContainsKey(name))
            {
                return Types[name];
            }

            Types.Add(name, complexType);
            return complexType;
        }
    }

    internal sealed class TypedName
    {
        public TypedName(SyntaxToken name, TypeSymbol? type)
        {
            Name = name;
            Type = type;
        }

        public SyntaxToken Name { get; }
        public TypeSymbol? Type { get; }
    }
}
