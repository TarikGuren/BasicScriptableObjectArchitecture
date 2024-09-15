using System;
using BasicScriptableObjectArchitecture.Runtime.Variables;

namespace BasicScriptableObjectArchitecture.Runtime.References
{
    [Serializable]
    public class FloatReference : GameReference<float, FloatVariable>
    {
        public FloatReference() : base() { }
        public FloatReference(float value) : base(value) { }
    }
}