using System;
using BasicScriptableObjectArchitecture.Runtime.Variables;
using UnityEngine;

namespace BasicScriptableObjectArchitecture.Runtime.References
{
    [Serializable]
    public class Vector2Reference : GameReference<Vector2, Vector2Variable>
    {
        public Vector2Reference() : base() { }
        public Vector2Reference(Vector2 value) : base(value) { }
    }
}