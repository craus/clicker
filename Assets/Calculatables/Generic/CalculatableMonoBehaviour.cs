using UnityEngine;
using System.Collections;

public abstract class CalculatableMonoBehaviour : MonoBehaviour, ICalculatable
{
    public abstract object CalculateToObject();
}
