using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    [SerializeField] private List<Obstacle> _obstacles;
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        foreach (var spawnPoint in _spawnPoints)
        {
            Instantiate(_obstacles[Random.Range(0, _obstacles.Count)], spawnPoint.transform);
        }
    }
}
