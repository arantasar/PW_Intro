using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : Interactable
{
    public GameObject player;
    public PlayerInteraction playerInteraction;

    void Start()
    {
        playerInteraction = player.GetComponent<PlayerInteraction>();
    }

    void Update()
    {
        HandleSubscribe();
    }
    protected override bool CanInteract()
    {
        var canInteract = Vector3.Distance(transform.position, player.transform.position) <= MaxDistanceToPlayer;
        return canInteract;
    }

    public override void Interact()
    {
        Debug.Log("Im interacting with the player!");
    }

    private void HandleSubscribe()
    {
        var canInteract = CanInteract();

        if (canInteract && playerInteraction.ObjectToInteract == null)
        {
            playerInteraction.SubscribeInteractable(gameObject.GetComponent<ItemInteraction>());
        }
        else if (!canInteract && playerInteraction.ObjectToInteract != null)
        {
            playerInteraction.UnsubscribeInteractable();
        }
    }
}
