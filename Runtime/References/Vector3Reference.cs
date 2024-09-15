using System;
using BasicScriptableObjectArchitecture.Variables;
using UnityEngine;

namespace BasicScriptableObjectArchitecture.References
{
    [Serializable]
    public class Vector3Reference : GameReference<Vector3, Vector3Variable>
    {
        public Vector3Reference() : base() { }
        public Vector3Reference(Vector3 value) : base(value) { }
    }
}