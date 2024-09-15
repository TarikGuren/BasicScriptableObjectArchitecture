using System;
using BasicScriptableObjectArchitecture.Variables;

namespace BasicScriptableObjectArchitecture.References
{
    [Serializable]
    public class StringReference : GameReference<string, StringVariable>
    {
        public StringReference() : base() { }
        public StringReference(string value) : base(value) { }
    }
}