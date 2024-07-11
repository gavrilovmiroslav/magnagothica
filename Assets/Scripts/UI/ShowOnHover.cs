using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOnHover : MonoBehaviour
{
    public GameObject target;

    private void OnMouseEnter()
    {
        target.SetActive(true);
    }

    private void OnMouseExit()
    {
        target.SetActive(false);
    }
}
