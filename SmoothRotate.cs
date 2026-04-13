using UnityEngine;

public class SmoothRotate : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 15f, 0); // Rotation speed
    public float smoothFactor = 5f;                         // Smoothness factor

    private Quaternion targetRotation;

    void Start()
    {
        targetRotation = transform.rotation;
    }

    void Update()
    {
        // Calculate the new rotation
        targetRotation *= Quaternion.Euler(rotationSpeed * Time.deltaTime);

        // Apply rotation smoothly using Slerp
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smoothFactor * Time.deltaTime);
    }
}