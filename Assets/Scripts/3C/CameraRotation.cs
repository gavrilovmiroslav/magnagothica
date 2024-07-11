using System.Collections;
using UnityEngine;

public class SmoothCameraRotate : MonoBehaviour
{
    public float RotationDuration = 1.0f;
    private bool IsRotating = false;

    void Update()
    {
        if (!IsRotating)
        {
            if (Input.GetButton("RotateLeft"))
            {
                StartCoroutine(RotateCamera(Vector3.up, -45, RotationDuration));
            }
            else if (Input.GetButton("RotateRight"))
            {
                StartCoroutine(RotateCamera(Vector3.up, 45, RotationDuration));
            }
        }
    }

    private IEnumerator RotateCamera(Vector3 axis, float angle, float duration)
    {
        IsRotating = true;
        Quaternion startRotation = transform.rotation;
        Quaternion endRotation = transform.rotation * Quaternion.Euler(axis * angle);
        float elapsedTime = 0.0f;

        while (elapsedTime < duration)
        {
            transform.rotation = Quaternion.Slerp(startRotation, endRotation, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.rotation = endRotation;
        IsRotating = false;
    }
}
