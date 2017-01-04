using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public abstract class CalculatableFloat : AbstractCalculatable<float>
{
    public float currentValue;

    public new string name;
    public string description;
    public string comment;

    public void Update() {
        currentValue = Calculate();

        if (this.Editor()) {
            this.SetName(name != "" ? "{0}{1}".i(name, comment != "" ? " ({0})".i(comment) : "") : BuildName());
        }
    }

    public virtual string BuildName() {
        return name;
    }

    protected string signedSummand(float summand) {
        if (summand > 0) {
            return "+" + summand.ToString();
        }
        if (summand < 0) {
            return "-" + (-summand).ToString();
        }
        return "";
    }

}
