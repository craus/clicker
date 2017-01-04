using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

[ExecuteInEditMode]
public class SaveManager : MonoBehaviour {
    public const float EPS = 1e-4f;

    public static SaveManager instance;

    public List<Resource> resources;

    void Awake() {
        instance = this;
    }

    void Update() {
        if (this.Editor()) {
            resources = FindObjectsOfType<Resource>().ToList();
        }
    }

    public void Backup() {
        resources.ForEach(r => r.Backup());
    }

    public void Restore() {
        resources.ForEach(r => r.Restore());
    }

    public bool CorrectState() {
        return resources.All(r => r.value > -EPS);
    }

    public bool Possible(List<ResourceChange> changes, float multiplier = 1) {
        Backup();
        changes.ForEach(c => c.Apply(multiplier));
        var result = CorrectState();
        Restore();
        return result;
    }
}
