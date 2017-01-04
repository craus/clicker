using UnityEngine;
using System.Collections;
using System;

public class TimeManager : MonoBehaviour {
    public static TimeManager instance;

    public event Action<int> onTicksPassed;

    public const float TICK_TIME = 0.01f;
    public float speed = 1f;

    public DateTime lastUpdateTime;

    void Awake() {
        instance = this;
    }

    void Start() {
        lastUpdateTime = DateTime.Now;
    }
    
    void Update() {
        UpdateTime();
        if (Input.GetKey(KeyCode.F)) {
            speed = 10f;
        } else {
            speed = 1f;
        }
    }

    private void UpdateTime() {
        var delta = DateTime.Now - lastUpdateTime;
        //Debug.LogFormat("Delta: {0}", delta);
        var ticks = (int)(delta.TotalSeconds / TICK_TIME * speed);
        //Debug.LogFormat("Update {0} ticks", ticks);
        lastUpdateTime += TimeSpan.FromSeconds(ticks * TICK_TIME / speed);
        onTicksPassed(ticks);
    }
}
