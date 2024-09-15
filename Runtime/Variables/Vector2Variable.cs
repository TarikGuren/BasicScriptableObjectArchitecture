using UnityEngine;

namespace BasicScriptableObjectArchitecture.Runtime.Variables
{
    [CreateAssetMenu(menuName = Constants.VARIABLE_BASE + "Vector2Variable", fileName = "Vector2Variable")]
    public class Vector2Variable : GameVariable<Vector2>
    {
    }
}