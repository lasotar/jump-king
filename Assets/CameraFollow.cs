using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;   // Object to follow
    public Vector3 offset;     // Offset from the target position

    void Start()
    {
        if (target == null)
        {
            Debug.LogError("No target assigned for CameraFollow script.");
        }
    }

    void LateUpdate()
    {
        if (target != null)
        {
            // Update the camera position to target + offset
            transform.position = target.position + offset;

            // Optional: keep camera's rotation fixed or match target's rotation
            // transform.rotation = target.rotation;
        }
    }
}