using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[ExecuteInEditMode]
public class Command : MonoBehaviour {
    public List<ResourceChange> prerequisite;
    public List<Condition> conditions;
    public List<ResourceChange> reward;
    public List<ResourceChange> cost;

    public bool Unlocked() {
        return SaveManager.instance.Possible(prerequisite, -1) && conditions.All(c => c.Satisfied());
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

    [ContextMenu("Make once")]
    void MakeOnce() {
        var condition = new GameObject().AddComponent<Inequality>();
        condition.variable = reward[0].resource;
        condition.sample = reward[0].amount;
        condition.less = true;
        condition.strict = true;
        condition.transform.SetParent(transform);
        conditions.Add(condition);
    }
}
