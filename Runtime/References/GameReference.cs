using BasicScriptableObjectArchitecture.Variables;
using Codice.CM.Triggers;

namespace BasicScriptableObjectArchitecture.References
{
    public class GameReference<T, TVariable> : Reference where TVariable : GameVariable<T>
    {
        public bool UseConstant = true;
        public T ConstantValue;
        public TVariable Variable;

        public GameReference()
        { }

        public GameReference(T value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public T Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
            set {
                if (UseConstant)
                    ConstantValue = value;
                else 
                    Variable.Value = value;
            }
        } 
        
        public static implicit operator T(GameReference<T, TVariable> reference)
        {
            return reference.Value;
        }
    }

    [System.Serializable]
    public abstract class Reference
    {
        
    }
}