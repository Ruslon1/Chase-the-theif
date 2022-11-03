using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerMover _playerMover;

    public event Action FinishedLevel;
    
    private void Start()
    {
        _playerMover = GetComponent<PlayerMover>();
    }

    public void ObstacleCollisionEnter()
    {
        _playerMover.SlowdownSpeed();
    }

    public void ObstacleCollisionExit()
    {
        _playerMover.IncreaseSpeed();
    }

    public void Finish()
    {
        FinishedLevel?.Invoke();
    }
}