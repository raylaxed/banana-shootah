using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Reference to the VideoPlayer component
    public string videoFilePath; // Path to the video file
    public Renderer videoRenderer; // Reference to the Renderer component of the 3D object

    private void Start()
    {
        // Set the video file path
        videoPlayer.url = videoFilePath;

        // Set the video to play on the assigned Renderer component
        videoPlayer.targetMaterialRenderer = videoRenderer;

        // Mute the audio of the video
        videoPlayer.audioOutputMode = VideoAudioOutputMode.None;

        // Prepare the VideoPlayer
        videoPlayer.Prepare();

        // Register the PrepareCompleted event to start playing the video
        videoPlayer.prepareCompleted += OnVideoPrepareCompleted;
    }

    private void OnVideoPrepareCompleted(VideoPlayer source)
    {
        // Start playing the video
        videoPlayer.Play();
    }
}
