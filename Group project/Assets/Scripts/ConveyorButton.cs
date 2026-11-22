using UnityEngine;

public class ConveyorButton : MonoBehaviour
{
    public BoxConveyor box;          

    void Update()
    {
        // Check for left mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Shoot a ray from the exact center of the main camera (0.5, 0.5)
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                // Check if the object in the center of the screen is THIS button
                if (hit.transform == transform && box != null)
                {
                    box.StartMoving();
                }
            }
        }
    }
}