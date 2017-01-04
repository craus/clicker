using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Derivative : TimedProcess {
    public CalculatableFloat derivative; 
    public ResourceChange change;

    void Update() {
        if (Extensions.Editor()) {
            gameObject.name = "{0} -> {1}".i(derivative.name, change);
        }
    }

    public override void OnTickPassed() {
        change.Apply(derivative.Calculate() * TimeManager.TICK_TIME);
    }
}
