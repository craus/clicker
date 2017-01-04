using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
[ExecuteInEditMode]
public class ResourceIndicator : MonoBehaviour {
    public Resource resource;

    public string format = "{0}: {1}";

    Text text;

    void Awake() {
        text = GetComponent<Text>();
    }

    void Update() {
        name = string.Format("{0} Text", resource.name);
        text.text = string.Format(format, resource.name, (int)resource.value);
    }
}
