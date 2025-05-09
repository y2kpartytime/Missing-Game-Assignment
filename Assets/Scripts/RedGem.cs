using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGem : MonoBehaviour
{
    public GameObject Gem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.hasRedGem = true;
            print("picked up red gem!");
            gameObject.SetActive(false);
        }
    }
}
