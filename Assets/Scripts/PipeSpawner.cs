using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject _pipe;
    public float _spawnRate = 2;
    private float _timer = 0;


    void Start()
    {
        SpawnPipe();
    }


    void Update()
    {
        if (_timer < _spawnRate)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            _timer = 0;
        }
    }

    private void SpawnPipe()
    {
        Instantiate(_pipe, transform.position, transform.rotation);
    }
}
