using UnityEngine;
using System.Collections;
using System;

[Serializable]
public abstract class TimedProcess : MonoBehaviour {
    public abstract void OnTickPassed();
}
