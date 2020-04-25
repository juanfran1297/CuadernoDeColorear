using UnityEngine;
using System.Collections;

public class ColisionColorea : MonoBehaviour {

	//creamos variable
	Color pintura;

	void OnTriggerStay2D (Collider2D other) 
    {
		if (other.tag == "BoteColores" && other.GetComponent<ColorArrastrar>().pintar == true) 
        {
			pintura = other.GetComponent<SpriteRenderer> ().color;
			this.GetComponent<SpriteRenderer> ().color = pintura;
		}
	}

}
