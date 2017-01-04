using UnityEngine;
using System.Collections;
using System;

[ExecuteInEditMode]
public class Inequality : Condition {
    public const float EPS = 1e-4f;
    public bool strict = false;
    public bool less = false;
    public float sample = 0;
    public CalculatableFloat variable;

    public override bool Satisfied() {
        return variable.Calculate() * (less ? -1 : 1) > sample * (less ? -1 : 1) + (strict ? EPS : -EPS);
    }

    public Inequality Strict() {
        this.strict = true;
        return this;
    }

    public void Update() {
        if (this.Editor()) {
            this.SetName("{0} {1}{2} {3}".i(variable, less ? "<" : ">", strict ? "" : "=", sample));
        }
        readonlySatisfied = Satisfied();
    }
}
