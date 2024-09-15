using UnityEngine;

namespace BasicScriptableObjectArchitecture.Runtime.Variables
{
    [CreateAssetMenu(menuName = Constants.VARIABLE_BASE + "StringVariable", fileName = "StringVariable")]
    public class StringVariable : GameVariable<string>
    {
    }
}