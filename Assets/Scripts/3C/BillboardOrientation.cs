using System.Collections;
using UnityEngine;

public class BillboardOrientation : MonoBehaviour
{
    void Update()
    {
        this.transform.rotation = Camera.main.transform.rotation;

        var scale = this.transform.localScale;
        var y = transform.rotation.eulerAngles.y;

        var shouldFlip = y >= 260 || y <= 115;
        scale.x = (shouldFlip ? -1 : 1) * Mathf.Abs(scale.x);
        this.transform.localScale = scale;
    }
}
