using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;
using System.Collections.Generic;

public class HiddableObject : MonoBehaviour {
    public List<ResourceChange> prerequisite;
    public List<Condition> conditions;

    public bool Show() {
        return SaveManager.instance.Possible(prerequisite, -1) && conditions.All(c => c.Satisfied());
    }
}
