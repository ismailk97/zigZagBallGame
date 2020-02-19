using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinTrigger : MonoBehaviour
{
    public static int count;
    public Text txt;





    // Use this for initialization
    void Start() {

        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {

        printCoins();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {

            Destroy(transform.parent.gameObject, 0);

            addScore();



        }
    }

    public void printCoins()
    {
        txt.text = "Score: " + count;
    }

    public void addScore(){
        count = +1;
    }
   
}
