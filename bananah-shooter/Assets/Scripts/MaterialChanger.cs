using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    // Drag and drop the materials you want to apply to the GameObject into these fields in the inspector
    [SerializeField]public Material material1;
    [SerializeField]public Material material2;
    [SerializeField]public Material material3;

    private Renderer _renderer;
    private Material[] _materials;
    private int _materialIndex = 0;

    private void Start()
    {
        // Get the Renderer component attached to the GameObject
        _renderer = GetComponent<Renderer>();

        // Store the materials in an array for easy access
        _materials = new Material[] { material1, material2, material3 };

        // Apply the first material to the GameObject
        _renderer.material = _materials[_materialIndex];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Increment the material index
            _materialIndex++;

            // Wrap around to the beginning if we've reached the end
            if (_materialIndex >= _materials.Length)
            {
                _materialIndex = 0;
            }

            // Apply the new material to the GameObject
            _renderer.material = _materials[_materialIndex];
        }
    }
}
