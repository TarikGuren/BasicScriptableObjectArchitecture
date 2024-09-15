using System;
using BasicScriptableObjectArchitecture.Runtime.Variables;

namespace BasicScriptableObjectArchitecture.Runtime.References
{
    [Serializable]
    public class IntReference : GameReference<int, IntVariable>
    {
        public IntReference() : base() { }
        public IntReference(int value) : base(value) { }
    }
}