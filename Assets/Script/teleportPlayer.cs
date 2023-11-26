using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    public Transform baseLocation;
    void Update()
    {
        // Check for player input to interact
        if(Input.GetKeyDown(KeyCode.G)){
            transform.position = baseLocation.position;
        }
        if (Input.GetKeyDown(KeyCode.Q)) // Assuming left mouse click for interaction
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Debug.Log("q pressed");
            if (Physics.Raycast(ray, out hit))
            {
                // Debug.Log("Object noted");
                Interactable interactable = hit.collider.GetComponent<Interactable>();

                if (interactable != null)
                {
                    Debug.Log("teleporting");
                    transform.position = interactable.destination.position;
                }
            }
        }
    }

    
}