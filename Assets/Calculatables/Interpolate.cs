using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[ExecuteInEditMode]
public class Interpolate : CalculatableString {
    public string format;
    public string currentValue;
    public List<CalculatableMonoBehaviour> args;

    public override string Calculate() {
        return format.i(args.Select(a => a.CalculateToObject()).ToArray());
    }

    void Update() {
        if (this.Editor()) {
            //gameObject.name = cal
            currentValue = Calculate();
        }
    }
}
