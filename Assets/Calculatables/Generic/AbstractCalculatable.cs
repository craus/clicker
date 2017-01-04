using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public abstract class AbstractCalculatable<T> : CalculatableMonoBehaviour, ICalculatable<T> {
    public abstract T Calculate();

    public override object CalculateToObject() {
        return Calculate();
    }

    public static implicit operator T(AbstractCalculatable<T> c) {
        return c.Calculate();
    }

    public override string ToString() {
        return name;
    }
}
