using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gong : MonoBehaviour, Interactible
{
    public bool canInteract;
    public Animator animator;
    public RoundManager roundManager;
    private AudioSource gongSound;

    // Start is called before the first frame update
    void Start()
    {
        //canInteract = false;
        canInteract = true;
        //gongSound = GameObject.Find("GongSound");
        gongSound = GetComponent<AudioSource>();
    }

    public void Interact()
    {
        canInteract = false;
        //AudioSource gongSoundToPlay = gongSound.GetComponent<AudioSource>();
        gongSound.Play();
        Debug.Log("sould play sound");
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

    public string GetInteractionInfo()
    {
        return "ring gong";
    }
}
