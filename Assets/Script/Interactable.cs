using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public GameObject popUpObject; // Reference to the pop-up object
    public Transform destination;
    public void Interact()
    {
        // Perform interactions here, like showing/hiding the pop-up
        // Debug.Log("Helo");
        if (popUpObject != null)
        {
            
            bool isActive = popUpObject.activeSelf;
            popUpObject.SetActive(!isActive);
        }
    }
    // public void TeleportPlayer()
    // {
    //     if (destination != null)
    //     {
    //         transform.position = destination.position;
    //     }
    // }
}
