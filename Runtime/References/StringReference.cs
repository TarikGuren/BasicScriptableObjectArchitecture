using System;
using BasicScriptableObjectArchitecture.Runtime.Variables;

namespace BasicScriptableObjectArchitecture.Runtime.References
{
    [Serializable]
    public class StringReference : GameReference<string, StringVariable>
    {
        public StringReference() : base() { }
        public StringReference(string value) : base(value) { }
    }
}