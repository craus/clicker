using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Pow : CalculatableFloat {
    public bool floored;
    public float multiplier = 1;
    public float shiftedY = 0;
    public float shiftedX = 0;

    public CalculatableFloat _base;
    public CalculatableFloat power;

    public override float Calculate() {
        var result = Mathf.Pow(_base+shiftedX, power);
        result *= multiplier;
        result += shiftedY;
        if (floored) {
            result = Mathf.Floor(result);
        }
        return result;
    }

    void Update() {
        if (this.Editor()) {
            gameObject.name = "{2}{0}^{1}{3}".i(_base, power, multiplier != 1 ? "{0}*".i(multiplier) : "", shiftedY != 0 ? "+{0}".i(shiftedY) : "");
        }
    }
}
