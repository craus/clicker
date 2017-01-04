using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[ExecuteInEditMode]
public class CommandButton : MonoBehaviour {
    public Command command;
    public Button button;

    void Awake() {
        button = GetComponent<Button>();
    }

    void Start() {
        button.onClick.AddListener(command.TryExecute);
    }

    void Update() {
        if (this.Editor()) {
            gameObject.name = GetComponentInChildren<Text>().text;
        } else {
            button.interactable = command.Available();
        }
    }
}
