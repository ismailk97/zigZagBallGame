using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedboost : MonoBehaviour {
    Rigidbody rb;
    public int boost = 10;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        rb.velocity = new Vector3(10, 0, 0);
    }
}
