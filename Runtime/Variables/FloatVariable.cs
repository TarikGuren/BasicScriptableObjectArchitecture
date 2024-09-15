using UnityEngine;

namespace BasicScriptableObjectArchitecture.Runtime.Variables
{
    [CreateAssetMenu(menuName = Constants.VARIABLE_BASE + "FloatVariable", fileName = "FloatVariable")]
    public class FloatVariable : GameVariable<float>
    {
    }
}