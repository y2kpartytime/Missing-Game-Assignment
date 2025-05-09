using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterCabin : MonoBehaviour
{
    public BoxCollider2D lodge;
    public BoxCollider2D cabin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (GameManager.Instance.hasRedGem == true)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
