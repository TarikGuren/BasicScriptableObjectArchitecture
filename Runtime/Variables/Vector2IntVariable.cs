﻿using UnityEngine;

namespace BasicScriptableObjectArchitecture.Variables
{
    [CreateAssetMenu(menuName = Constants.VARIABLE_BASE + "Vector2IntVariable", fileName = "Vector2IntVariable")]
    public class Vector2IntVariable : GameVariable<Vector2Int>
    {
    }
}