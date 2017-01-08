using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Function : CalculatableFloat {
    public Resource argument;
    public CalculatableFloat argumentValue;

    public CalculatableFloat expression;

    public override float Calculate() {
        float v = argument.value;
        argument.value = argumentValue.Calculate();
        float result = expression.Calculate();
        argument.value = v;
        return result;
    }

    public override string BuildName() {
        return expression.ToString().Replace(argument.ToString(), argumentValue.ToString());
    }
}
