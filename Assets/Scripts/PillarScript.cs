using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarScript : MonoBehaviour
{

    public GameObject Andrea;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pillar"))
        {
            GameManager.Instance.foundAndrea = true;
            Andrea.SetActive(true);
        }
    }
}
