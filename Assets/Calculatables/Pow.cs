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
        var result = Mathf.Pow(_base, power + shiftedX);
        result *= multiplier;
        result += shiftedY;
        if (floored) {
            result = Mathf.Floor(result);
        }
        return result;
    }

    public override void Update() {
        base.Update();
        if (this.Editor()) {
            this.SetName("{2}{0}^{1}{3}".i(
                _base, 
                shiftedX != 0 ? "({0}{1})".i(power, signedSummand(shiftedX)) : power.ToString(),
                multiplier != 1 ? "{0}*".i(multiplier) : "", 
                shiftedY != 0 ? signedSummand(shiftedY) : ""
            ));
        }
    }

    [ContextMenu("AddShiftedX")]
    public void AddShiftedX() {
        shiftedX += 1;
        UnityEditor.Undo.RecordObject(this, "Shifted X");
    }
}
