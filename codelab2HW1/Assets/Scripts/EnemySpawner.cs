using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameManager myManager;
    public GameObject[] circles;
    public float timeGap;
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", timeGap);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        if (!myManager.gameOver)
        {
            num = Random.Range(0, 4);// 0,1,2,3  (inclusive,not inclusive)
            GameObject enemy = Instantiate(circles[num]);
            enemy.transform.position = new Vector3(Random.Range(-8.3f, 8.3f),
                                                                           Random.Range(4.5f, -4.5f),
                                                                           transform.position.z);
            Invoke("Spawn", timeGap);
        }

       

    }





}
