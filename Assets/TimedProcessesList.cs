using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[ExecuteInEditMode]
public class TimedProcessesList : MonoBehaviour {
    public List<TimedProcess> processes;

    void Start() {
        FindObjectOfType<TimeManager>().onTicksPassed += OnTicksPassed; 
    }

    void OnTicksPassed(int ticks) {
        for (int i = 0; i < ticks; i++) {
            processes.ForEach(p => p.OnTickPassed());
        }
    }

    void UpdateProcessesList() {
        processes = FindObjectsOfType<TimedProcess>().ToList();
    }

    void Update() {
        if (Extensions.Editor()) {
            UpdateProcessesList();
        }
    }
}
