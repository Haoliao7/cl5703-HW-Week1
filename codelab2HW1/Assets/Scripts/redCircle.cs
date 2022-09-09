using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redCircle : MonoBehaviour
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
        Invoke("DestroyCircle", myEnemySpawner.GetComponent<EnemySpawner>().timeGap); // destroy it after specific sec
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("right");
            myGameManager.GetComponent<GameManager>().score++; //add score
            myEnemySpawner.GetComponent<EnemySpawner>().timeGap -= 0.02f;//make the game faster
            Instantiate(coinSoundPlayer);//play coin sound
            Destroy(gameObject);//destroy it
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)) {

            myGameManager.GetComponent<GameManager>().gameOver = true;//gameover if press the wrong buttons
            Destroy(gameObject);

        }

    }

    private void DestroyCircle()
    {
        myGameManager.GetComponent<GameManager>().gameOver = true;//game over it it's too late
        Destroy(gameObject);
    }
}
