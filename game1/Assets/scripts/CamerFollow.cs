using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollow : MonoBehaviour {
    public GameObject ball;
    Vector3 offsett;
  public float lerpRate;
    bool gameover;
	// Use this for initialization
	void Start () {
        offsett = ball.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (!gameover)
        {
            Follow();
        }
	}

    void Follow()
    {
        Vector3 pos = transform.position;
        Vector3 targetPos = ball.transform.position - offsett;
       pos = Vector3.Lerp(pos, targetPos, lerpRate * Time.deltaTime);
        transform.position = pos;
    }
}
