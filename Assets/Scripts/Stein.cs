using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stein : MonoBehaviour {
    public GameObject steine;

    void OnCollisionEnter (Collision other) {
        Instantiate(steine, transform.position, Quaternion.identity);
        Main.instance.DestroyBrick();
        Destroy(gameObject);
    }
}
