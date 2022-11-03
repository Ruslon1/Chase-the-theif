using System;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMover _playerMover;
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
        _playerMover = GetComponent<PlayerMover>();
    }

    private void FixedUpdate() => ScanTouch();

    private void ScanTouch()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 position = ScreenToWorldPosition(Input.mousePosition);
            _playerMover.MoveHorizontally(position.x);
        }
    }

    private Vector3 ScreenToWorldPosition(Vector3 argument)
    {
        var coefficientZ = 2;
        argument.z = coefficientZ;
        return _camera.ScreenToWorldPoint(argument);
    }
}