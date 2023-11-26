using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactor : MonoBehaviour
{
    public float interactionRange = 2; // Range of interaction

    void Update()
    {
        // Check for player input to interact
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, interactionRange))
            {
                
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                Debug.Log(interactable);
                if (interactable != null)
                {
                    // Debug.Log("e");
                    // Perform interaction if an interactable object is hit
                    interactable.Interact();
                }
            }
        }
    }
}
