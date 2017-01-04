using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Resource : CalculatableFloat {
    public float value;
    public float backup;

    public override string BuildName() {
        return "{0}{1}".i(name, comment != "" ? " ({0})".i(comment) : "");
    }

    public override float Calculate() {
        return value;
    }

    public void Backup() { 
        backup = value;
    }

    public void Restore() {
        value = backup;
    }
}
