using UnityEngine;

namespace BasicScriptableObjectArchitecture.Variables
{
    [CreateAssetMenu(menuName = Constants.VARIABLE_BASE + "StringVariable", fileName = "StringVariable")]
    public class StringVariable : GameVariable<string>
    {
    }
}