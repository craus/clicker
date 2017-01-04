using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[ExecuteInEditMode]
public class Product : CalculatableFloat {
    public List<CalculatableFloat> multiples;

    public override float Calculate() {
        return multiples.Aggregate(1f, (acc, x) => acc * x);
    }

    public override void Update() {
        base.Update();
        if (this.Editor()) {
            this.SetName(multiples.ExtToString("*", "{0}"));
        }
    }
}
