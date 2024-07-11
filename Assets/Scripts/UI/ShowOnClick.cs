using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOnClick : MonoBehaviour
{
    public static Dictionary<string, GameObject> CurrentHovers = new();

    public string group;
    public GameObject target;
    public bool shouldHideOnMouseExit = false;
    private void OnMouseDown()
    {
        if (CurrentHovers.ContainsKey(group))
        {
            CurrentHovers[group].SetActive(false);
            CurrentHovers.Remove(group);
        }
        target.SetActive(true);
        CurrentHovers.Add(group, target);
    }

    private void OnMouseExit()
    {
        if (shouldHideOnMouseExit) 
            target.SetActive(false);
    }
}
