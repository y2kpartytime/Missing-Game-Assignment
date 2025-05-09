using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outhouse : MonoBehaviour
{
    public GameObject gem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gem.SetActive(true);
        }
    }
}
