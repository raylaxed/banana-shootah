using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            PlaySound();
            Debug.Log("keyDown");
        }
    }

    void PlaySound()
    {
        Debug.Log("playSound");
        audioSource.Play();
    }
}
