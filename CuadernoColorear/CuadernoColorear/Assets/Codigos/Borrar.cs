using UnityEngine;
using System.Collections;

public class Borrar : MonoBehaviour {

	//Variable almacena las partes que se colorean.
	GameObject[] plantilla;


	// Use this for initialization
	void Start () {
		// La variable plantilla tendra los objetos con el tag PiezasColores
		plantilla = GameObject.FindGameObjectsWithTag ("Piezas");

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	//Cuando se pulsa en un objeto(en este caso un botón) cojera el color de este y se lo pondrá a las piezas
	void OnMouseDown () {
		foreach (GameObject go in plantilla) {
			go.GetComponent<SpriteRenderer> ().color = Color.white;
		}

	}
}
