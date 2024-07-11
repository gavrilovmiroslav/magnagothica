using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class GlowOnClick : MonoBehaviour
{
    public static Dictionary<string, TMPro.TextMeshProUGUI> CurrentHovers = new();

    public string group;
    public bool shouldStopOnMouseExit = false;

    private void OnMouseDown()
    {
        if (CurrentHovers.ContainsKey(group))
        {
            CurrentHovers[group].alignment = TMPro.TextAlignmentOptions.Left;
            CurrentHovers.Remove(group);
        }

        var txt = GetComponent<TMPro.TextMeshProUGUI>();
        txt.alignment = TMPro.TextAlignmentOptions.Right;
        CurrentHovers.Add(group, txt);
    }

    private void OnMouseExit()
    {
        if (shouldStopOnMouseExit)
        {
            var txt = GetComponent<TMPro.TextMeshProUGUI>();
            txt.alignment = TMPro.TextAlignmentOptions.Left;
        }
    }
}
