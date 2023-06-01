using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gong : MonoBehaviour, Interactible
{
    public bool canInteract;
    public Animator animator;
    public RoundManager roundManager;

    // Start is called before the first frame update
    void Start()
    {
        //canInteract = false;
        canInteract = true;
    }

    public void Interact()
    {
        canInteract = false;
        animator.SetTrigger("Ring");
        roundManager.NewRound();
    }

    public bool CanInteract()
    {
        return canInteract;
    }

    public void MakeInteractable()
    {
        canInteract = true;
    }

}
