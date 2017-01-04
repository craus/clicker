using UnityEngine;
using System.Collections;

public interface ICalculatable<T> {
    T Calculate();
}

public interface ICalculatable
{
    object CalculateToObject();
}
