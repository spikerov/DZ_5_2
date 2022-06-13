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
        for (int i = 0; i < _spawnPoints.Count; i++)
        {
            Instantiate(_cirlePrefab, _spawnPoints[i].transform);
            yield return new WaitForSeconds(2);
        }
    }
}
