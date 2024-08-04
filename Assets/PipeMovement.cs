using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public float _moveSpeed = 5f;

    void Start()
    {
        
    }


    void Update()
    {
        transform.position = transform.position + (Vector3.left * _moveSpeed) * Time.deltaTime;
    }
}
