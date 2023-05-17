using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHanlderScript : MonoBehaviour
{
    public GameObject heartPrefab;
    public float heartCount;
    public float spacing = 1.0f;
    public Transform heartContainer;

    void Start()
    {
        Entity playerEntity = GameObject.Find("Player").GetComponent<Entity>();
        heartCount = playerEntity.Health;
        
        Debug.Log("healthStart");
        Debug.Log(heartCount);
        RefreshHearts();
    }

    


    // Update is called once per frame
    void Update()
    {
        
        Entity playerEntity = GameObject.Find("Player").GetComponent<Entity>();
        heartCount = playerEntity.Health;
        Debug.Log("healthUpdate");
        Debug.Log(heartCount);
        RefreshHearts();
       
    }
 public void RefreshHearts()
{
    // Zuerst löschen wir alle vorhandenen Herzen
    foreach (Transform child in heartContainer)
    {
        Destroy(child.gameObject);
    }

    // Dann erstellen wir neue Herzen basierend auf der aktuellen Spieler-Gesundheit
    for (int i = 0; i < heartCount; i++)
    {
        
        GameObject heart = Instantiate(heartPrefab, heartContainer);
        Vector3 position = new Vector3(i * spacing, 0f, 0f);
        heart.transform.localPosition = position;
        heart.SetActive(true);
    }
}
    
}
