using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public Texture2D crosshairTexture;
    private Color invertedColor;

    private void Start()
    {
        // Calculate inverted color based on camera background color
        invertedColor = Color.white - Camera.main.backgroundColor;
    }

    private void OnGUI()
    {
        // Calculate the position of the crosshair in the middle of the screen
        float crosshairSize = 20f;
        Vector2 crosshairPosition = new Vector2((Screen.width - crosshairSize) / 2f, (Screen.height - crosshairSize) / 2f);

        // Set the color to the inverted color
        GUI.color = invertedColor;

        // Draw the crosshair
        GUI.DrawTexture(new Rect(crosshairPosition.x, crosshairPosition.y, crosshairSize, 1), crosshairTexture); // Horizontal line
        GUI.DrawTexture(new Rect(crosshairPosition.x, crosshairPosition.y, 1, crosshairSize), crosshairTexture); // Vertical line

        // Reset GUI color to default
        GUI.color = Color.white;
    }
}
