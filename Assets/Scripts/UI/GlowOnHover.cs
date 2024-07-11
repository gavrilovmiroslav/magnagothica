using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class GlowOnHover : MonoBehaviour
{
    public static Dictionary<string, TMPro.TextMeshProUGUI> CurrentHovers = new();

    public string group;
    public bool shouldStopOnMouseExit = false;

    private void OnMouseEnter()
    {
        var txt = GetComponent<TMPro.TextMeshProUGUI>();
        if (CurrentHovers.ContainsKey(group))
        {
            var hoverOverSelected = GlowOnClick.CurrentHovers.ContainsKey(group) &&
                GlowOnClick.CurrentHovers[group] != CurrentHovers[group];

            if (!hoverOverSelected)
            {
                CurrentHovers[group].alignment = TMPro.TextAlignmentOptions.Left;
                CurrentHovers.Remove(group);
            }
        }

        txt.alignment = TMPro.TextAlignmentOptions.Right;
        CurrentHovers.Add(group, txt);
    }

    private void OnMouseExit()
    {
        var txt = GetComponent<TMPro.TextMeshProUGUI>();
        if (GlowOnClick.CurrentHovers.ContainsKey(group) && GlowOnClick.CurrentHovers[group] == txt) return;
        if (shouldStopOnMouseExit)
        {
            txt.alignment = TMPro.TextAlignmentOptions.Left;
        }
    }
}
