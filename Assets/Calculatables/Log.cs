using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Log : CalculatableFloat {
    public bool floored;
    public float multiplier = 1;
    public float shiftedY = 0;
    public float shiftedX = 0;
    public float shiftedBase = 0;

    public CalculatableFloat _base;
    public CalculatableFloat x;

    public override float Calculate() {
        var result = Mathf.Log(x + shiftedX, _base + shiftedBase);
        result *= multiplier;
        result += shiftedY;
        if (floored) {
            result = Mathf.Floor(result);
        }
        return result;
    }

    public override string BuildName() {
        return "{2}log({0}, {1}){3}".i(
            shiftedX != 0 ? "{0}{1}".i(x, signedSummand(shiftedX)) : x.ToString(),
            shiftedBase != 0 ? "({0}{1})".i(_base, signedSummand(shiftedBase)) : _base.ToString(),
            multiplier != 1 ? "{0}*".i(multiplier) : "",
            shiftedY != 0 ? signedSummand(shiftedY) : ""
        );
    }
}
