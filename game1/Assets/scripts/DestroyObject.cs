using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "ball")
        {
            Destroy(transform.parent.gameObject, 0.5F);
        }
    }
}
