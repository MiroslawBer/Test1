using UnityEngine;
using System.Collections;

public class RuchGracza : MonoBehaviour {

	float predkoscGracza = 0.0f;

	// Awake wykonuje się tylko raz, przy uruchomieniu sceny przed Start
	void Awake() {
		predkoscGracza = GetComponent<Gracz> ().Predkosc;
	}

	// Use this for initialization
	void Start () {
	
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			// GetComponent<Transform> ().Translate (new Vector3 (-1, 0, 0));
			// pełna wersja powyżej a skrócona (jego zmienna systemowa) poniżej
			transform.Translate (new Vector3 (-predkoscGracza, 0, 0));
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			transform.Translate (new Vector3 (predkoscGracza, 0, 0));
		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			transform.Translate (new Vector3 (0, 0, predkoscGracza));
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			transform.Translate (new Vector3 (0, 0, -predkoscGracza));
		}
			

	}
}
