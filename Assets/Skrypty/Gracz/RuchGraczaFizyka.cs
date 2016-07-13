using UnityEngine;
using System.Collections;

public class RuchGraczaFizyka : MonoBehaviour {

	// nadajemy w inspektorze parametry


	float predkoscGracza = 0.0f;

	// Awake wykonuje się tylko raz, przy uruchomieniu sceny przed Start
	void Awake() {
		predkoscGracza = GetComponent<Gracz> ().Predkosc;
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame, wywoływany jest co klatkę
	// FixedUpdate wywoływane jest przez silnik fizyki
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (-1, 0, 0) * predkoscGracza;
			// zamiast "new Vector3 (-1, 0, 0)" można wpisać "Vector.left" - robi to samo
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (1, 0, 0) * predkoscGracza;
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 1) * predkoscGracza;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, -1) * predkoscGracza;
		} else {
			GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
		}
	}
}
