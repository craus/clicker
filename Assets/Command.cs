using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[ExecuteInEditMode]
public class Command : MonoBehaviour {
    public List<ResourceChange> prerequisite;
    public List<ResourceChange> cost;
    public List<ResourceChange> reward;

    public bool Unlocked() {
        return SaveManager.instance.Possible(prerequisite, -1);
    }

    public bool Available() {
        return SaveManager.instance.Possible(cost, -1);
    }

    public void Execute() {
        cost.ForEach(c => c.Apply(-1));
        reward.ForEach(c => c.Apply());
    }

    public void TryExecute() {
        if (Unlocked() && Available()) {
            Execute();
        } else {
            Debug.LogError("Locked command execution attempt!");
        }
    }

    void Update() {
        if (this.Editor()) {
            gameObject.name = "Buy {0} for {1}".i(reward.ExtToString(), cost.ExtToString());
        }
    }
}
