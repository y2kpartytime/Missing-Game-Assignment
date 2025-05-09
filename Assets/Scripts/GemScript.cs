using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GemScript : MonoBehaviour
{
    public GameObject Gem;
    public GameObject Harry;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Gem.SetActive(true);
            Harry.SetActive(true);
            PlayerMovement playerscript = collision.GetComponent<PlayerMovement>();
            playerscript.hasGem = true;
            
        }
    }
}
