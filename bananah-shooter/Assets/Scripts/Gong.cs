using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gong : MonoBehaviour, Interactible
{
    public bool canInteract;
    public Animator animator;
    public RoundManager roundManager;
    private GameObject gongSound;

    // Start is called before the first frame update
    void Start()
    {
        //canInteract = false;
        canInteract = true;
        gongSound = GameObject.Find("GongSound");

       // gongSound = GetComponent<GongSound>();
    }

    public void Interact()
    {
        canInteract = false;
        AudioSource gongSoundToPlay = gongSound.GetComponent<AudioSource>();
        gongSoundToPlay.Play();
        Debug.Log("sould play sound");
        animator.SetTrigger("Ring");
        
       // gongSound.Play();
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
