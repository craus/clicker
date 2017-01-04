using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class ResourceChange {
    public Resource resource;
    public CalculatableFloat amount;

    public void Apply(float multiplier = 1) {
        resource.value += amount * multiplier;
    }

    public override string ToString() {
        return "{0} {1}".i(amount, resource);
    }
}
