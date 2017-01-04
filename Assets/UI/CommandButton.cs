using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[ExecuteInEditMode]
public class CommandButton : HiddableObject {
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
            prerequisite = command.prerequisite;
            conditions = command.conditions;
        } else {
            button.interactable = command.Available();
        }
    }
}
