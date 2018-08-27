using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        Vector3 adjustedMovement = transform.TransformDirection(Vector3.forward);
        rb.AddForce(adjustedMovement * 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
