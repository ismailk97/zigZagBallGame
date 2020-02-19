using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggercheck : MonoBehaviour {

  

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            
            Invoke("falldown", 0.5F);
           
            }
        

    }

    public void falldown()
    {
        GetComponentInParent<Rigidbody>().useGravity = true;
        Destroy(transform.parent.gameObject, 1);
    }
}
