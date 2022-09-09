using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenCiclre : MonoBehaviour
{
    GameObject myEnemySpawner;
    SpriteRenderer mySpriteRenderer;
    GameObject myGameManager;
    public GameObject coinSoundPlayer;
    // Start is called before the first frame update
    void Start()
    {
        myGameManager = GameObject.Find("GameManager");
        myEnemySpawner = GameObject.Find("EnemySpawner");
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        Invoke("DestroyCircle", myEnemySpawner.GetComponent<EnemySpawner>().timeGap);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("up");
            myGameManager.GetComponent<GameManager>().score++;
            myEnemySpawner.GetComponent<EnemySpawner>().timeGap -= 0.02f;
            Instantiate(coinSoundPlayer);
            Destroy(gameObject);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {

            myGameManager.GetComponent<GameManager>().gameOver = true;
            Destroy(gameObject);


        }

    }

    private void DestroyCircle()
    {
        myGameManager.GetComponent<GameManager>().gameOver = true;
        Destroy(gameObject);
    }

    
}
