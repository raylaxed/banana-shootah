using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHanlderScript : MonoBehaviour
{
    public GameObject heartPrefab;
    public float heartCount;
    public float spacing = 100.0f;
    public Transform heartContainer;
    private List<GameObject> hearts = new List<GameObject>();

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
     // Lösche vorhandene Herzen
        foreach (GameObject heart in hearts)
        {
            Destroy(heart);
        }
        hearts.Clear();

        // Erstelle neue Herzen basierend auf der aktuellen Gesundheit
        for (int i = 0; i < heartCount; i++)
        {
            GameObject heart = Instantiate(heartPrefab, transform);
            Vector3 position = new Vector3(i * spacing, 0f, 0f);
            heart.transform.localPosition = position;
            heart.SetActive(i < heartCount); // Aktiviere/deaktiviere Herzen basierend auf der aktuellen Gesundheit
            hearts.Add(heart);
        }
    
}
    
}
