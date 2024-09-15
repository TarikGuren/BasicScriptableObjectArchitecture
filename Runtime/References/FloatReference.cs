using System;
using BasicScriptableObjectArchitecture.Variables;

namespace BasicScriptableObjectArchitecture.References
{
    [Serializable]
    public class FloatReference : GameReference<float, FloatVariable>
    {
        public FloatReference() : base() { }
        public FloatReference(float value) : base(value) { }
    }
}