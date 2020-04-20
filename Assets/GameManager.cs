using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject _pipe;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipe", 2.0f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    SpawnPipe()
    {
        Instantiate(_pipe, transform.position, Quaternion.Identity);
    }
}
