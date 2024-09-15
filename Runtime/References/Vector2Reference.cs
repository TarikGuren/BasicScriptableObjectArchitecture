using System;
using BasicScriptableObjectArchitecture.Variables;
using UnityEngine;

namespace BasicScriptableObjectArchitecture.References
{
    [Serializable]
    public class Vector2Reference : GameReference<Vector2, Vector2Variable>
    {
        public Vector2Reference() : base() { }
        public Vector2Reference(Vector2 value) : base(value) { }
    }
}