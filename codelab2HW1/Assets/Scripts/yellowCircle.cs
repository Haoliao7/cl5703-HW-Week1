using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowCircle : MonoBehaviour
{
    GameObject myEnemySpawner;
    SpriteRenderer mySpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {

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
            Destroy(gameObject);
        }

    }

    private void DestroyCircle()
    {
        Destroy(gameObject);
    }
}
