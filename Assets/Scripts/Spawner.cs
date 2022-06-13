using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private List<Transform> _spawnPoints;

    private void Start()
    {
        StartCoroutine(EnemySpawner());
    }

    private IEnumerator EnemySpawner()
    {
        for (int i = 0; i < _spawnPoints.Count; i++)
        {
            Instantiate(_enemyPrefab, _spawnPoints[i].transform);
            yield return new WaitForSeconds(2);
        }
    }
}
