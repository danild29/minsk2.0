using Minsk.CodeAnalysis.Binding;
using Minsk.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Minsk.CodeAnalysis
{
    public class ObjectsInstance
    {
        public ComplexTypeSymbol Type { get; set; }

        public IEnumerable<object> Objects { get; set; }

        public ObjectsInstance(ComplexTypeSymbol type, IEnumerable<object> objects)
        {
            Type = type;
            Objects = objects;
        }

        internal object? GetValue(string name)
        {

            for (int i = 0; i < Type.Fields.Count(); i++)
            {
                if (Type.Fields.ElementAt(i) == name)
                    return Objects.ElementAt(i);
            }

            // in binder we already checked that field exist;
            throw new Exception($"Field '{name}' in class '{Type.Name}' was not found");
        }

        public IEnumerable<string> Fields => Type.Fields;
    }
}