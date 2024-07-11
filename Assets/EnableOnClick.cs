using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOnClick : MonoBehaviour
{
    public GameObject Target;

    private void OnMouseDown()
    {
        Target.SetActive(true);    
    }
}
