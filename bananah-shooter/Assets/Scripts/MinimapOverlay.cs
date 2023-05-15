using UnityEngine;

public class MinimapOverlay : MonoBehaviour
{
    public Transform player;  // Der Spieler, dessen Position auf der Minimap angezeigt werden soll
    public Camera minimapCamera;  // Die Kamera für die Minimap-Ansicht
    public RenderTexture minimapTexture;  // Die Render-Textur für die Minimap-Ansicht

    void LateUpdate()
    {
        Vector3 newPosition = player.position;  // Aktualisiere die Position des Spielers

        newPosition.y = transform.position.y;  // Behalte die Y-Position der Minimap-Kamera bei

        transform.position = newPosition;  // Aktualisiere die Position der Minimap-Kamera

        // Rotiere die Minimap-Kamera entsprechend der Spielerrotation
        transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
    }

    void OnGUI()
    {
        // Zeichne die Minimap-Textur als Overlay
        GUI.DrawTexture(new Rect(10, 10, 1720, 200), minimapTexture, ScaleMode.ScaleToFit, false);
    }
}
