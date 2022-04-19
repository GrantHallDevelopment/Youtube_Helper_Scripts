using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeResizer : MonoBehaviour
{
    public Canvas canvas;
    RectTransform thisRect;

    private void Start()
    {
        ResetSize();
    }

    public void ResetSize()
    {
        thisRect = GetComponent<RectTransform>();

        Rect safeArea = Screen.safeArea;

        Vector2 anchorMin = safeArea.position;
        Vector2 anchorMax = safeArea.position + safeArea.size;

        anchorMin.x /= canvas.pixelRect.width;
        anchorMin.y /= canvas.pixelRect.height;
        anchorMax.x /= canvas.pixelRect.width;
        anchorMax.y /= canvas.pixelRect.height;

        thisRect.anchorMin = anchorMin;
        thisRect.anchorMax = anchorMax;
    }
}
