using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitHouse : MonoBehaviour
{
    public bool hasGem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerMovement playerscript = collision.GetComponent<PlayerMovement>();
            if (playerscript != null && playerscript.hasGem)
            {
                SceneManager.LoadScene(0);
            }
        }
        
    }
}
