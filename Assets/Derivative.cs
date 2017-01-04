using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Derivative : TimedProcess {
    public Resource derivative; 
    public Resource resource;
    public float speed = 1;

    void Update() {
        if (Extensions.Editor()) {
            if (this.resource == null) {
                this.resource = GetComponent<Resource>();
            }
            gameObject.name = "{0} -> {1}".i(derivative.name, resource.name);
        }
    }

    public override void OnTickPassed() {
        resource.value += derivative.value * speed;
    }
}
