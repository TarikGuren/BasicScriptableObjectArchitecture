﻿using UnityEngine;

namespace BasicScriptableObjectArchitecture.Variables
{
    [CreateAssetMenu(menuName = Constants.VARIABLE_BASE + "Vector3Variable", fileName = "Vector3Variable")]
    public class Vector3Variable : GameVariable<Vector3>
    {
    }
}