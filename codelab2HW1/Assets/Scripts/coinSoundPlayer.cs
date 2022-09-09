using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSoundPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyThis", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroyThis()
    {
        Destroy(gameObject);
    }
}
