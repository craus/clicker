using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;
using System.Collections.Generic;

public class HiddableObjects : MonoBehaviour {
    public List<HiddableObject> hiddableObjects;

    void Awake() {
        hiddableObjects = FindObjectsOfType<HiddableObject>().ToList();
    }

    void Update() {
        hiddableObjects.ForEach(b => b.gameObject.SetActive(b.Show()));
    }
}
