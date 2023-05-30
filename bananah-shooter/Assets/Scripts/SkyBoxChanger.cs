using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEditor;

public class SkyBoxChanger : MonoBehaviour
{
    [System.Serializable]
    public struct SkyboxData
    {
        public Material skyboxMaterial;
        public LightingSettings lightingSettings;
        public GameObject directionalLight;
    }

    public SkyboxData[] skyboxes;
    private int currentIndex = 0; // Current index of the skybox
    private GameObject currentDirectionalLight;


    // Start is called before the first frame update
    void Start()
    {
        // Set first Skybox in Array
        SetSkyboxAndLighting(currentIndex);
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
        // Increment the index and wrap around
        currentIndex = (currentIndex + 1) % skyboxes.Length;
        
        SetSkyboxAndLighting(currentIndex);
    }

    void SetSkyboxAndLighting(int index)
    {
        // Change the skybox material
        RenderSettings.skybox = skyboxes[index].skyboxMaterial;
        //Change lighting Settings
        Lightmapping.lightingSettings = skyboxes[index].lightingSettings;

        // Change Directional Light
        GameObject newDirectionalLight = skyboxes[index].directionalLight;

        if (currentDirectionalLight != null)
        {
            Destroy(currentDirectionalLight);
        }

        if (newDirectionalLight != null)
        {
            currentDirectionalLight = Instantiate(newDirectionalLight);
            currentDirectionalLight.transform.position = newDirectionalLight.transform.position;
            currentDirectionalLight.transform.rotation = newDirectionalLight.transform.rotation;
        }
    }
}
