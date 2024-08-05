using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeThreshold : MonoBehaviour
{
    [Header("References")]
    public LogicManager logic;
    //public Bird _bird;

    void Start()
    {
        // grab Bird script for _isBirdAlive state
        //_bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<Bird>();
        // grab Logic script for AddScore() method
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!_bird._isBirdAlive)
            return;
        else
        {
            if (collision.gameObject.layer == 3)
                logic.AddScore(1);
        }
    }
    */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
            logic.AddScore(1);
    }
}
