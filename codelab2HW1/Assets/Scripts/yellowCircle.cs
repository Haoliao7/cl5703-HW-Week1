using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowCircle : MonoBehaviour
{
    GameObject myEnemySpawner;
    SpriteRenderer mySpriteRenderer;
    GameObject myGameManager;
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
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("left");
            myGameManager.GetComponent<GameManager>().score++;
            myEnemySpawner.GetComponent<EnemySpawner>().timeGap -= 0.02f;
            Destroy(gameObject);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
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
