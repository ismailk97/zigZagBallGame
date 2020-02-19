using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UiManager : MonoBehaviour {

    public static UiManager instance;
    public GameObject PlayPanel;
    public GameObject GameOverPanel;
    public Text Score;
    public Text HighScore;
    public Text HighScore2;
    public GameObject playtext;



    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Use this for initialization
    void Start () {
		
	}


    public void GameStart()
    {
        
            playtext.SetActive(false);
        PlayPanel.GetComponent<Animation>().Play("PlayDisapear");

    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
    }

    //brukes til å resete spillet
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
