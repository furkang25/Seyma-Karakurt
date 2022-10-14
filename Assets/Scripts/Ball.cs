using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float anfangsgeschwindigkeit = 600f;

    private Rigidbody rb;
    private bool spielen;

    // Start is called before the first frame update
    void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1") && spielen == false) {
            transform.parent = null;
            spielen = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(anfangsgeschwindigkeit, anfangsgeschwindigkeit, 0));
        }
    }
}
