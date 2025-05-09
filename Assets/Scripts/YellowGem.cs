using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowGem : MonoBehaviour
{

    public GameObject gem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.hasYellowGem = true;
            print("Picked up yellow gem!");
            gem.SetActive(false);
        }
    }
}
