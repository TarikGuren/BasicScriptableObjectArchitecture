using UnityEngine;

namespace BasicScriptableObjectArchitecture.Runtime.Variables
{
    [CreateAssetMenu(menuName = Constants.VARIABLE_BASE + "IntVariable", fileName = "IntVariable")]
    public class IntVariable : GameVariable<int>
    {
    }
}