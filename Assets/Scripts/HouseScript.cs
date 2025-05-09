using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseScript : MonoBehaviour
{
    public BoxCollider2D lodge;
    public BoxCollider2D cabin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerMovement playerscript = collision.GetComponent<PlayerMovement>();
            if (playerscript != null && playerscript.hasGem)
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
