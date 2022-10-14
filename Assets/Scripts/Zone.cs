using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour {
    void OnTriggerEnter (Collider col) {
        Main.instance.LoseLife();
    }
}
