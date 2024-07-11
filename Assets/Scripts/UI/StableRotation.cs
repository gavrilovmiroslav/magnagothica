using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StableRotation : MonoBehaviour
{
    public float Rotation = 0.01f;

    void Update()
    {
        this.transform.Rotate(0, 0, Rotation);
    }
}
