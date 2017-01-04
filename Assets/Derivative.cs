using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[ExecuteInEditMode]
public class Derivative : TimedProcess {
    public CalculatableFloat derivative;
    public List<ResourceChange> change;
    public List<ResourceChange> prerequisite;

    void Update() {
        if (Extensions.Editor()) {
            gameObject.name = "{0} -> {1}".i(derivative, change.ExtToString());
        }
    }

    public override void OnTickPassed() {
        if (SaveManager.instance.Possible(prerequisite, -1)) {
            change.ForEach(c => c.Apply(derivative.Calculate() * TimeManager.TICK_TIME));
        }
    }
}
