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
        scoreText.text = "Score : " + score.ToString();

        if (gameOver)
        {
            gameOverText.SetActive(true);
            enemySpawner.SetActive(false);
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }


}
