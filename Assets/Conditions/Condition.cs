using UnityEngine;
using System.Collections;
using System;

public abstract class Condition : MonoBehaviour {
    public bool readonlySatisfied;

    public abstract bool Satisfied();
}
