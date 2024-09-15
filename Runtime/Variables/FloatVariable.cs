using UnityEngine;

namespace BasicScriptableObjectArchitecture.Variables
{
    [CreateAssetMenu(menuName = Constants.VARIABLE_BASE + "FloatVariable", fileName = "FloatVariable")]
    public class FloatVariable : GameVariable<float>
    {
    }
}