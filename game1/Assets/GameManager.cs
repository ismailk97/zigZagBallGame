using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public bool gameover;
    

  public   void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

	// Use this for initialization
 public void Start () {
        gameover = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


   public void StartGame()
    {
        UiManager.instance.GameStart();
       
    }
    
    public  void GameOver()
    {
        UiManager.instance.GameOver();

    }
}
