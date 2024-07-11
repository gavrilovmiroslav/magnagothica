using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float Speed = 0.2f;
    public float ZoomFactor = 0.0f;

    void Update()
    {
        var h = Input.GetAxis("Horizontal") * Speed;
        var v = Input.GetAxis("Vertical") * Speed;
        var z = Input.GetAxis("Zoom") * ZoomFactor;

        var f = Camera.main.transform.forward;
        var fn = new Vector3(f.x, 0.0f, f.z);
        var r = Camera.main.transform.right;
        this.transform.position += fn * v + r * h;
        this.transform.GetChild(0).transform.position += f * z;
    }
}
