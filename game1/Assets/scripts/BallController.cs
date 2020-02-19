using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public GameObject ball;
    Rigidbody rb;
    public float speed;
    public bool gameover;
    public float thrust;
   public bool started = false;
    // Use this for initialization


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {

     
        

    }
   
    // Update is called once per frame
    void Update() {

        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                
                rb.velocity = new Vector3(speed, 0, 0);
                started = true;

                GameManager.instance.StartGame();
            }
        }
       

            if (Input.GetMouseButtonDown(0))
                {
                    Direction();
                }

        /*

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(-speed, 0, 0);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(0, 0, -speed);
        }



        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
        */

        if (!Physics.Raycast(transform.position, Vector3.down, 1F))
        {
            gameover = true;
            rb.velocity = new Vector3(0, -25, 0);
            Destroy(ball,1);

            
        }

    }


    void Direction(){
        if(rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }

        else if(rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, speed);
        }

}

    
}
