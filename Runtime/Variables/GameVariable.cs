using UnityEngine;

namespace BasicScriptableObjectArchitecture.Variables
{
    public abstract class GameVariable<T> : GameVariable
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public T Value;

        public void SetValue(T value)
        {
            Value = value;
        }

        public void SetValue(GameVariable<T> value)
        {
            Value = value.Value;
        }
    }

    public abstract class GameVariable : ScriptableObject
    {
    }
}