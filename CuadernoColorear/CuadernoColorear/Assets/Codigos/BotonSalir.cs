using UnityEngine;
using System.Collections;

public class BotonSalir : MonoBehaviour {



	void OnMouseDown() {
		
		//cargamos el valor del componente SpriteRenderer. Color lo modificamos.
		this.gameObject.GetComponent<SpriteRenderer> ().color = new Color32 (180, 67, 121,255);
		this.gameObject.GetComponent<AudioSource> ().Play();
		Application.Quit();
	}


}
