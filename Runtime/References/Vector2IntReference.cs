using System;
using BasicScriptableObjectArchitecture.Runtime.Variables;
using UnityEngine;

namespace BasicScriptableObjectArchitecture.Runtime.References
{
    [Serializable]
    public class Vector2IntReference : GameReference<Vector2Int, Vector2IntVariable>
    {
        public Vector2IntReference() : base() { }
        public Vector2IntReference(Vector2Int value) : base(value) { }
    }
}