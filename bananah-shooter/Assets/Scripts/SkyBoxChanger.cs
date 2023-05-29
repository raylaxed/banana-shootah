using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxChanger : MonoBehaviour
{
    public Material[] skyboxes; // Array of skybox materials
    private int currentIndex = 0; // Current index of the skybox

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = skyboxes[currentIndex]; // Set the initial skybox
    }

    // Update is called once per frame
    void Update()
    {
        //this is just for testing
        if(Input.GetKeyDown(KeyCode.E))
        {
            ChangeSkybox();
        }
    }

    public void ChangeSkybox()
    {
        currentIndex = (currentIndex + 1) % skyboxes.Length; // Increment the index and wrap around
        RenderSettings.skybox = skyboxes[currentIndex]; // Change the skybox to the new material
    }
}
