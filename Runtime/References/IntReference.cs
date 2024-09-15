using System;
using BasicScriptableObjectArchitecture.Variables;

namespace BasicScriptableObjectArchitecture.References
{
    [Serializable]
    public class IntReference : GameReference<int, IntVariable>
    {
        public IntReference() : base() { }
        public IntReference(int value) : base(value) { }
    }
}