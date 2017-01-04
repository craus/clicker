using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[ExecuteInEditMode]
public class Derivative : TimedProcess {
    public CalculatableFloat derivative; 
    public List<ResourceChange> change;

    void Update() {
        if (Extensions.Editor()) {
            gameObject.name = "{0} -> {1}".i(derivative.name, change.ExtToString());
        }
    }

    public override void OnTickPassed() {
        change.ForEach(c => c.Apply(derivative.Calculate() * TimeManager.TICK_TIME));
    }
}
