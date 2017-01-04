using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
[ExecuteInEditMode]
public class DynamicText : MonoBehaviour {
    public CalculatableString value;
    public Text text;

    void Awake() {
        text = GetComponent<Text>();
    }

    void Update() {
        text.text = value;
    }
}
