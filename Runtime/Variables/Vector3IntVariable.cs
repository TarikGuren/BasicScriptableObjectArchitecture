using UnityEngine;

namespace BasicScriptableObjectArchitecture.Runtime.Variables
{
    [CreateAssetMenu(menuName = Constants.VARIABLE_BASE + "Vector3IntVariable", fileName = "Vector3IntVariable")]
    public class Vector3IntVariable : GameVariable<Vector3Int>
    {
    }
}