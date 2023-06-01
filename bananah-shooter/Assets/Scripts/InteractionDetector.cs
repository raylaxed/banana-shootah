using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script also works when there are more interactible objects next to each other, but right now we only have one
public class InteractionDetector : MonoBehaviour
{
    private List<Interactible> interactiblesInRange = new List<Interactible>();

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && interactiblesInRange.Count > 0)
        {
            var interactible = interactiblesInRange[0];
            interactible.Interact();

            if(!interactible.CanInteract())
            {
                interactiblesInRange.Remove(interactible);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // checks if an interactible object is in range and adds it to the list
        var interactible = other.GetComponent<Interactible>();
        if(interactible != null && interactible.CanInteract())
        {
            interactiblesInRange.Add(interactible);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // removes the object from the list if it is not in range anymore
        var interactible = other.GetComponent<Interactible>();
        if(interactiblesInRange.Contains(interactible))
        {
            interactiblesInRange.Remove(interactible);
        }

    }
}
