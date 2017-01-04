﻿using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Resource : CalculatableFloat {
    public new string name;
    public float value;
    public float backup;

    public override void Update() {
        base.Update();
        if (this.Editor()) {
            gameObject.name = name;
        }
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
