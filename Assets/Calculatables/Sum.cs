using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[ExecuteInEditMode]
public class Sum : CalculatableFloat {
    public List<CalculatableFloat> summands;

    public float shiftedY;

    public override float Calculate() {
        return summands.Aggregate(0f, (acc, x) => acc + x) + shiftedY;
    }
    public override string BuildName() {
        return summands.ExtToString("+", "{0}");
    }
}
