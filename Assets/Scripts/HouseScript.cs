using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseScript : MonoBehaviour
{
    public bool hasGem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && hasGem == true)
        {
            SceneManager.LoadScene(2);
        }
    }
}
