using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasOff : MonoBehaviour
{
    public Canvas thisCanvas;
    // Start is called before the first frame update
    void Start()
    {
        thisCanvas = GetComponent<Canvas>();
    }

    public void OffCanvas()
    {
        thisCanvas.enabled = false;
    }

    private void OnMouseDown()
    {
        OffCanvas();
    }
}
