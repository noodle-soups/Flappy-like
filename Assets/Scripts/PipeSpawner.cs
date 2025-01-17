using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [Header("References")]
    public GameObject _pipe;

    [Header("Spawn Function")]
    public float _spawnRate = 2;
    private float _timer = 0;
    [SerializeField] private float _heightOffset = 10f;


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
        float _lowestPoint = transform.position.y - _heightOffset;
        float _highestPoint = transform.position.y + _heightOffset;
        Instantiate(_pipe, new Vector3(transform.position.x, Random.Range(_lowestPoint, _highestPoint), 0), transform.rotation);
    }
}
