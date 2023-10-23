using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class souns : MonoBehaviour
{
    public GameObject JumpScare;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {
            JumpScare.SetActive(true);
        }
    }
}