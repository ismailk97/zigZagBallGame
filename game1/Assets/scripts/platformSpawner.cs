using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class platformSpawner : MonoBehaviour {
    public bool gameover;
    public GameObject platform;
    public GameObject coins;
    
    Vector3 lastPos;
    float size;

	// Use this for initialization
	void Start () {
        lastPos = platform.transform.position;
        size = platform.transform.localScale.x;

        for (int i=0; i<25; i++)
        {
            SpawnPlatforms();
        }

        InvokeRepeating("SpawnPlatforms", 2f, 0.2F);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void SpawnX()
    {
        Vector3 pos = lastPos;
        pos.x += size;
        lastPos = pos;
        Instantiate(platform, pos, Quaternion.identity);
        int rand = Random.Range(0, 4);
        if (rand < 1)
        {
            Instantiate(coins, new Vector3(pos.x, pos.y + 1, pos.z), coins.transform.rotation);
        }

       

    }

    void SpawnZ()
    {
        Vector3 pos = lastPos;
        pos.z += size;
        lastPos = pos;
        Instantiate(platform, pos, Quaternion.identity);
        int rand = Random.Range(0, 4);
        if (rand < 1)
        {
            Instantiate(coins, new Vector3(pos.x, pos.y + 1, pos.z), coins.transform.rotation);
        }
    }

    void SpawnPlatforms()
    {
        int ran = Random.Range(0, 7);
        if(ran <= 3)
        {
            SpawnX();
        }

        else {
            SpawnZ();
        }
    }
}
