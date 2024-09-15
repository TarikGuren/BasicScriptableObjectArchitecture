using System;
using BasicScriptableObjectArchitecture.Variables;
using UnityEngine;

namespace BasicScriptableObjectArchitecture.References
{
    [Serializable]
    public class Vector3IntReference : GameReference<Vector3Int, Vector3IntVariable>
    {
        public Vector3IntReference() : base() { }
        public Vector3IntReference(Vector3Int value) : base(value) { }
    }
}