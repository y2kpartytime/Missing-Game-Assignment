using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissingGemScript : MonoBehaviour
{
    public GameObject Person;
    public GameObject Gem;
    private bool found = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && found == false)
        {
            Person.SetActive(true);
            Gem.SetActive(true);
            DontDestroyOnLoad(Person);
            found = true;
        }
    }
}
