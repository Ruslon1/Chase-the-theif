using System;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Vector3 _offset;
    
    private void Update()
    {
        Following();
    }

    private void Following()
    {
        var targetPosition = _player.transform.position;
        targetPosition = _player.transform.position + _offset;
        targetPosition.x = transform.position.x;
        transform.position = targetPosition;
    }
}
