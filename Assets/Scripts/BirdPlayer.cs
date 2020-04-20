using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdPlayer : MonoBehaviour
{
    Rigidbody2D _rb;
    float thrust = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            _rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
        }
    }
}
