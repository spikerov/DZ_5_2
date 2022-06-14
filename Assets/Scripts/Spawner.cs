using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private Queue<Transform> _queueSpawnPoints = new Queue<Transform>();

    private float _timeAfterSpawn = 0;
    private float _timeBetweenSpawnEnemy = 2;

    private void Start()
    {
        TransferListToQuewe();
    }

    private void Update()
    {
        _timeAfterSpawn += Time.deltaTime;

        while (_timeAfterSpawn >= _timeBetweenSpawnEnemy && _queueSpawnPoints != null)
        {
            _timeAfterSpawn -= _timeBetweenSpawnEnemy;
            EnemySpawner();
        }
    }

    private void TransferListToQuewe()
    {
        for (int i = 0; i < _spawnPoints.Count; i++)
        {
            _queueSpawnPoints.Enqueue(_spawnPoints[i]);
        }
    }

    private void EnemySpawner()
    {
        Instantiate(_enemyPrefab, _queueSpawnPoints.Dequeue());
    }
}
