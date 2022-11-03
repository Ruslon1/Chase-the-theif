using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _xPositionInMiddle;
    private Player _player;
    private bool _endedLevel;

    private void Awake()
    {
        _player = GetComponent<Player>();
        _xPositionInMiddle = transform.position.x;
    }

    private void OnEnable()
    {
        _player.FinishedLevel += OnFinishedLevel;
    }

    private void OnDisable()
    {
        _player.FinishedLevel -= OnFinishedLevel;
    }

    private void Update()
    {
        if (_endedLevel == false)
            Move();
    }

    public void MoveHorizontally(float x)
    {
        Debug.Log("Horizontally");
        var nextPosition = transform.position;
        nextPosition.x = x;
        transform.position = nextPosition;
    }

    public void SlowdownSpeed()
    {
        _speed -= 1f;
    }

    public void IncreaseSpeed()
    {
        _speed += 1f;
    }

    private void OnFinishedLevel()
    {
        _endedLevel = true;
        MoveToMiddle();
    }

    private void Move()
    {
        transform.position += Vector3.forward * _speed * Time.deltaTime;
    }

    private void MoveToMiddle()
    {
        Vector3 targetPosition = transform.position;
        targetPosition.x = _xPositionInMiddle;
        transform.Translate(targetPosition);
    }
}