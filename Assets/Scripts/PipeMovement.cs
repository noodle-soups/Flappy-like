using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public float _moveSpeed = 5f;
    [SerializeField] private float _deadZone = -50f;

    void Update()
    {

        // move pipe from right to left
        transform.position = transform.position + (Vector3.left * _moveSpeed) * Time.deltaTime;
        
        // destroy pipe once pos.x hits dead zone
        if (transform.position.x <= _deadZone)
            Destroy(gameObject);
    }
}
