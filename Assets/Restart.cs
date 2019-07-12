using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public void Update() {
        if (UnityEngine.Input.GetMouseButton(0) || UnityEngine.Input.touchCount > 0) {
            this.Reroll();
        }
    }

    public void Reroll() {
        Debug.Log("Rerolling !");
        foreach (string id in new List<string> {"Fate Die 1", "Fate Die 2", "Fate Die 3", "Fate Die 4"}) {
            GameObject.Find(id).SendMessage("Reroll");
        }
    }
}
