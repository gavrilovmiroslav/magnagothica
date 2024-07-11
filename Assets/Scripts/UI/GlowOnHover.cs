using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowOnHover : MonoBehaviour
{
    private void OnMouseEnter()
    {
        var txt = GetComponent<TMPro.TextMeshProUGUI>();
        txt.alignment = TMPro.TextAlignmentOptions.Right;
    }

    private void OnMouseExit() {
        var txt = GetComponent<TMPro.TextMeshProUGUI>();
        txt.alignment = TMPro.TextAlignmentOptions.Left;
    }

}
