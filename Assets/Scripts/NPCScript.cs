using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            switch (gameObject.tag)
            {
                case "Andrea":
                    GameManager.Instance.foundAndrea = true;
                    print("Found Andrea!");
                    break;
                case "Harry":
                    GameManager.Instance.foundHarry = true;
                    print("Found Harry!");
                    break;
                case "Martin":
                    GameManager.Instance.foundMartin = true;
                    print("Found Martin!");
                    break;
                case "OldMan":
                    GameManager.Instance.foundOldMan = true;
                    print("Found Old Man!");
                    break;
            }
            if (GameManager.Instance.foundAndrea &&GameManager.Instance.foundHarry && GameManager.Instance.foundMartin && GameManager.Instance.foundOldMan)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}

