using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Const : CalculatableFloat
{
    public float value;

    public override float Calculate() {
        return value;
    }

    void Update() {
        if (this.Editor()) {
            gameObject.name = value.ToString();
        }
    }
}
