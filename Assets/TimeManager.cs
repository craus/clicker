using UnityEngine;
using System.Collections;
using System;

public class TimeManager : MonoBehaviour {
    public event Action<int> onTicksPassed;

    const double TICK_TIME = 0.01f;

    public DateTime lastUpdateTime;

    void Start() {
        lastUpdateTime = DateTime.Now;
    }
    
    void Update() {
        UpdateTime();
    }

    private void UpdateTime() {
        var delta = DateTime.Now - lastUpdateTime;
        //Debug.LogFormat("Delta: {0}", delta);
        var ticks = (int)(delta.TotalSeconds / TICK_TIME);
        //Debug.LogFormat("Update {0} ticks", ticks);
        lastUpdateTime += TimeSpan.FromSeconds(ticks * TICK_TIME);
        onTicksPassed(ticks);
    }
}
