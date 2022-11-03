using System;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            player.Finish();
            Debug.Log("finish");
        }
    }
}