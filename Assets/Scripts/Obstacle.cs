using System;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Init");
    }

    private void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            player.ObstacleCollisionEnter();
            Debug.Log("Collision");
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.TryGetComponent(out Player player))
        {
            player.ObstacleCollisionExit();
        }
    }
}
