using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Const : CalculatableFloat
{
    public float value;

    public override float Calculate() {
        return value;
    }

    public override void Update() {
        base.Update();
        if (this.Editor()) {
            this.SetName(value.ToString());
        }
    }
}
