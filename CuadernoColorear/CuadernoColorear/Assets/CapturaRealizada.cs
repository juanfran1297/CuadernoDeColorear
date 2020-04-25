using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturaRealizada : MonoBehaviour
{
    public GameObject canvasGaleria;

    private void Start()
    {
        canvasGaleria = GameObject.Find("CanvasGaleria");
    }
    private void OnMouseDown()
    {
        canvasGaleria.SetActive(false);
    }
}
