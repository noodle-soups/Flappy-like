using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    // references
    [Header("References")]
    public Rigidbody2D _rb;

    // references
    [Header("Flap")]
    public float _flapStrength;


    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            _rb.velocity = Vector2.up * _flapStrength;
        }

    }
}
