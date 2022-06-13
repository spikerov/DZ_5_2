using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArea : MonoBehaviour
{
    [SerializeField] private GameObject _cirlePrefab;
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    private void Start()
    {
        StartCoroutine(SpawnCircle());
    }

    private IEnumerator SpawnCircle()
    {
        while (_spawnPoints.Count > 0)
        {
            Instantiate(_cirlePrefab, _spawnPoints[Random.Range(0, _spawnPoints.Count + 1)].transform);
            yield return new WaitForSeconds(2);
        }
    }
}
