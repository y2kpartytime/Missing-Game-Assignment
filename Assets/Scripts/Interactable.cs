using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    public Light lampLight;
    public GameObject propLamp;
    public AudioClip soundLamp;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Matches")
        {
            Debug.Log("Collided with CollisionArea");
        }
        else if (other.gameObject.name == "Water")
        {
            Debug.Log("Triggered TriggerArea");
        }
    }
}