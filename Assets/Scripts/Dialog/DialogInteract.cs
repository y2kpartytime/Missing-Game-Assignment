using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public string[] dialogLines;
    public GameObject dialogBox;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DialogScript dialog = FindObjectOfType<DialogScript>();
            dialogBox.SetActive(true);
            
            if (dialog != null)
            {
                dialog.StartDialog(dialogLines);
            }
        }
    }
}

