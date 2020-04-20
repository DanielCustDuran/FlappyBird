using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * 0.03f;
        if(transform.position.x < 0){
            Vector3 pos = transform.position;
            transform.position =  new Vector3(3, pos.y, pos.z);
        }
    }
}
