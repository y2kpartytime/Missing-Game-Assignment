using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCabin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (collision.CompareTag("Player") && GameManager.Instance.hasRedGem)
            {
                GameManager.Instance.foundMartin = true;
                SceneManager.LoadScene(1);
            }
        }
    }
}
