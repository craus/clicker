using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
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
        button.interactable = command.Available();
    }
}
