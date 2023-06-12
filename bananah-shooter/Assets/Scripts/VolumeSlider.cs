using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider volumeSlider; // Reference to the UI slider
    public AudioSource audioSource; // Reference to the audio source

    private void Start()
    {
        // Set the initial value of the slider to the current volume
        volumeSlider.value = audioSource.volume;

        // Add a listener to the slider's OnValueChanged event
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
    }

    private void OnVolumeChanged(float volume)
    {
        // Update the volume of the audio source
        audioSource.volume = volume;
        AudioListener.volume = volume;
    }
}
