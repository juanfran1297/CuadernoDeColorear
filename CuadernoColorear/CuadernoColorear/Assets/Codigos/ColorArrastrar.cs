using UnityEngine;
using System.Collections;

public class ColorArrastrar : MonoBehaviour {


	float distancia = 10f;
	Vector3 posicionRaton, posicionDestino;

	//Creamos variable para el objeto seleccionado
	public GameObject colorElegido;


	// Creamos variable para color
	public bool pintar;

	/*void Update(){
		if (Input.GetMouseButton (0)) {
			colorElegido.GetComponent<ColorArrastrar> ().pintar = true;
		}
	}*/

	void OnMouseDown() {
		
		// Crea una copia Instancia del objeto seleccionado.
		colorElegido = Instantiate (this.gameObject, this.transform.position, this.transform.rotation) as GameObject;
		colorElegido.GetComponent<CircleCollider2D> ().radius = 0.05f;


	}


	
	void OnMouseDrag(){
		//Capturamos la posición del ratón
		posicionRaton = Input.mousePosition;
		// traforma las coordenadas de la posición del ratón
		posicionDestino=Camera.main.ScreenToWorldPoint(new Vector3 (posicionRaton.x, posicionRaton.y, distancia)); 
		// en coordenadas del mundo. La variable distancia
		posicionDestino.z = 0f; 
		// se utiliza para para asignar una posición en z
		colorElegido.transform.position = posicionDestino;                                                            
		// si está a 0 falla la conversión
		//Debug.Log (posicionDestino); 
		//Debug.Log (colorElegido.GetComponent<CircleCollider2D> ().radius);
		}

	//Cuando soltamos se destrulle el objeto que tenemos agarrado, este está en la variable colorElegido.
	
	void OnMouseUp() {

		// La instancia se convierte en true.
		colorElegido.GetComponent<ColorArrastrar> ().pintar = true;
		//Modificamos el tamaño del collider de color que arrastramos
		Destroy (colorElegido, 0.1f);
		//Debug.Log ("up");
	}
		
	
}