using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falldown : MonoBehaviour {

    
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!Physics.Raycast(transform.position, Vector3.down, 1))
        {
            
            rb.velocity = new Vector3(0, -9, 0);
        }
    }
}
