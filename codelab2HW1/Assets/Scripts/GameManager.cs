using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public bool gameOver;
    public GameObject gameOverText;
    public GameObject enemySpawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + score.ToString(); // display score on screen

        if (gameOver) // if the game is over
        {
            gameOverText.SetActive(true);//display "Game over"
            enemySpawner.SetActive(false); // stop the spawner

            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0); // load menu scene if pressing space
            }

        }

    }



}
