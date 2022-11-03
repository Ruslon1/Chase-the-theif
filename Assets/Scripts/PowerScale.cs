using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerScale : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void Awake()
    {
        _player.FinishedLevel += Enable;
    }

    private void Enable()
    {
        gameObject.SetActive(true);
    }
}
