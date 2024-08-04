using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    // references
    [Header("References")]
    public Rigidbody2D _rb;
    public LogicManager logic;

    [Header("States")]
    public bool _isBirdAlive = true;

    // references
    [Header("Flap")]
    public float _flapStrength;


    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isBirdAlive)
            _rb.velocity = Vector2.up * _flapStrength;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        _isBirdAlive = false;
    }
}
