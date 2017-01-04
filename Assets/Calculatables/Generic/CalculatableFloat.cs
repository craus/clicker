using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public abstract class CalculatableFloat : AbstractCalculatable<float>
{
    public float currentValue;

    public virtual void Update() {
        currentValue = Calculate();
    }

    protected string signedSummand(float summand) {
        if (summand > 0) {
            return "+" + summand.ToString();
        }
        if (summand < 0) {
            return "-" + (-summand).ToString();
        }
        return "";
    }

}
