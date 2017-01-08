using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[ExecuteInEditMode]
public class Ceiling : CalculatableFloat {
    public CalculatableFloat arg;

    public override float Calculate() {
        return Mathf.Ceil(arg);
    }
    public override string BuildName() {
        return "[!{0}]".i(arg.name);
    }
}
