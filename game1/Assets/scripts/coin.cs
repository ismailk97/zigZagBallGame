using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class coin : MonoBehaviour {
   
    
    Rigidbody rb;
    public float speed;
   
	// Use this for initialization
	void Start () {
        
	}

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        rb.transform.Rotate(Vector3.up, speed, Space.World);
	}

  

}
