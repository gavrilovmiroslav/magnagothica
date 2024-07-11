using Unity;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    public Camera camera;
    public float rot = 200;
    public void Update()
    {
        var p = camera.ScreenToWorldPoint(
            new Vector3(
                Input.mousePosition.x, 
                Input.mousePosition.y, 
                camera.transform.position.z));

        Debug.Log(p);
        var t = this.GetComponent<RectTransform>();
        
        t.LookAt(p);
        t.Rotate(0, rot, 0);

        var r = t.rotation;
        r.y = 0;
        t.rotation = r;
    }
}
