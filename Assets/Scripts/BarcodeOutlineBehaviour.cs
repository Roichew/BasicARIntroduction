using UnityEngine;
using Vuforia;

public class BarcodeOutlineBehavior : MonoBehaviour
{
    // Reference to the ImageTargetBehaviour that holds the barcode target
    public ImageTargetBehaviour imageTargetBehaviour;

    // Reference to the outline material
    public Material outlineMaterial;

    // Reference to the outline object
    private GameObject outlineObject;

    void Start()
    {
        // Create the outline object as a child of the ImageTarget
        outlineObject = new GameObject("Outline");
        outlineObject.transform.parent = imageTargetBehaviour.transform;
        outlineObject.transform.localPosition = Vector3.zero;

        // Add a MeshRenderer component to the outline object
        MeshRenderer renderer = outlineObject.AddComponent<MeshRenderer>();

        // Apply the outline material to the MeshRenderer
        renderer.material = outlineMaterial;

        // Hide the outline initially
        outlineObject.SetActive(false);
    }

    // Method to show the outline
    public void ShowOutline()
    {
        outlineObject.SetActive(true);
    }

    // Method to hide the outline
    public void HideOutline()
    {
        outlineObject.SetActive(false);
    }
}
