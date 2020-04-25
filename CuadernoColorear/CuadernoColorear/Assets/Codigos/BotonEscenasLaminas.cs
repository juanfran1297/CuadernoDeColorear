using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//Indicamos que carge lalibreria de UI de unity.
//using UnityEngine.UI;

//Cargamos esta libreria para poder utilizar la nueva forma de cargar escenas (SceneManager.LoadScene("");)
//using UnityEngine.SceneManagement;

public class BotonEscenasLaminas : MonoBehaviour {

    //Variable donde pondremos la imagen del UI
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
		StartCoroutine (CargoEscena ());
	}






	IEnumerator CargoEscena(){
		//Esperamos 1 segundo
		yield return new WaitForSeconds (0);
        if(SceneManager.GetActiveScene().name == "MenuPrincipal")
        {
            Application.LoadLevel("LaminasMenu");
        }
        else
        {
            //Cargamos la escena
            Application.LoadLevel("LaminasMenu");
        }
        

		
	}


}
