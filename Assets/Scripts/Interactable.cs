using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField]
    protected float MaxDistanceToPlayer = 5f;
    protected virtual bool CanInteract() 
    {
        return false;
    }
    public virtual void Interact() { }

}
