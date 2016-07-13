using UnityEngine;
using System.Collections;

public class Gracz : MonoBehaviour {

	//Michal

	// definicje zmiennych
	// domyślnie prywatne
	[SerializeField] float predkosc = 1.0f;
	// SerializeField oznacza zmienna dalej prywatną ale mozliwą do regulacji w silniku

	// Use this for initialization
	// wykonuje gdy sie włącza scena
	void Start () {
	
	}
	
	// Update is called once per frame
	// wykonuje sie co klatkę
	void Update () {
			
	}

	// jeżeli wykryje kolizje to wykona się ta metoda
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Domek1") {
			Debug.Log ("Kolizaj z domkiem");
		}
	}

	// Property
	public float Predkosc {
		get { return predkosc; }
		set { predkosc = value; }
		// dostęp set: gracz.Predkosc = 13.4f;
		// dostęp get: float naszaWartosc = gracz.Predkosc;
	}

}
