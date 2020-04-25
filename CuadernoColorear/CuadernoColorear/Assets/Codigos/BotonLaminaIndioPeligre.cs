using UnityEngine;
using System.Collections;

public class BotonLaminaIndioPeligre : MonoBehaviour {

	//public Image fundido;

	void OnMouseDown() {

		//cargamos el valor del componente SpriteRenderer. Color lo modificamos.
		this.gameObject.GetComponent<SpriteRenderer> ().color = new Color32 (180, 67, 121,255);
		this.gameObject.GetComponent<AudioSource> ().Play();
	}

	void OnMouseUp() {
		this.gameObject.GetComponent<SpriteRenderer> ().color = new Color32 (255, 255, 255,255);
		this.gameObject.GetComponent<BoxCollider2D> ().enabled = false;
		//fundido.CrossFadeAlpha (1, 0.5f, false);
		//fundidoLaminas.CrossFadeAlpha (1, 0.5f, false);
		StartCoroutine (CargoEscena ());
	}


	IEnumerator CargoEscena(){
		//Esperamos 1 segundo
		yield return new WaitForSeconds (0);
		//Cargamos la escena
		Application.LoadLevel ("PeligreBajo");
	}
}
