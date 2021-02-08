using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Interactable ObjectToInteract;

    private void InteractWithInteractable()
    {
        if (ObjectToInteract != null && Input.GetKeyDown(KeyCode.E))
        {
            ObjectToInteract.GetComponent<Interactable>().Interact();
        }
    }

    public void SubscribeInteractable(Interactable interactable)
    {
        this.ObjectToInteract = interactable;
    }

    public void UnsubscribeInteractable()
    {
        ObjectToInteract = null;
    }

    void Update()
    {
        InteractWithInteractable();
    }


}
