using System;
using BasicScriptableObjectArchitecture.Runtime.Variables;
using UnityEngine;

namespace BasicScriptableObjectArchitecture.Runtime.References
{
    [Serializable]
    public class Vector3IntReference : GameReference<Vector3Int, Vector3IntVariable>
    {
        public Vector3IntReference() : base() { }
        public Vector3IntReference(Vector3Int value) : base(value) { }
    }
}