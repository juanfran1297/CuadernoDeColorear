using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffPrueba : MonoBehaviour
{

    //public GameObject thisRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }
}
