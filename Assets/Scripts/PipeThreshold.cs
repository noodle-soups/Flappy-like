using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeThreshold : MonoBehaviour
{
    [Header("References")]
    public LogicManager logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.AddScore();
    }

}
