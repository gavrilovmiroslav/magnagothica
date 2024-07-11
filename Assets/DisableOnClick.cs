using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnClick : MonoBehaviour
{
    public GameObject Target;

    private void OnMouseDown()
    {
        Target.SetActive(false);
    }
}
