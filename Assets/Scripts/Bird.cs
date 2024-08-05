using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    [Header("References")]
    public Rigidbody2D _rb;
    public LogicManager logic;

    [Header("States")]
    public bool _isBirdAlive = true;

    [Header("Flap")]
    public float _flapStrength;

    [Header("Y Death Zone")]
    [SerializeField] private float _yDeathZone;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    void Update()
    {
        YDeathZone();
        FlapMovement();
    }

    private void FlapMovement()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isBirdAlive)
            _rb.velocity = Vector2.up * _flapStrength;
    }

    private void YDeathZone()
    {
        if (Mathf.Abs(transform.position.y) > _yDeathZone)
        {
            _isBirdAlive = false;
            logic.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        _isBirdAlive = false;
    } 

}
