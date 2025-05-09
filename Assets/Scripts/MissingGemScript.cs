using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissingGemScript : MonoBehaviour
{
    public GameObject Person;
    public GameObject Gem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Person.SetActive(true);
            PlayerMovement playerscript = collision.GetComponent<PlayerMovement>();
            Gem.SetActive(true);
        }
    }
}
