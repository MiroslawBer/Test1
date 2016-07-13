using UnityEngine;
using System.Collections;

public class OtwieranieDrzwi : MonoBehaviour {

	bool drzwiOtwarte = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown(){
		if (drzwiOtwarte) {
			transform.FindChild ("BrylaDrzwi").RotateAround (transform.FindChild ("Zawiasy").position, Vector3.up, 90);
			drzwiOtwarte = false;
			Debug.Log ("pukamy i otwieramy");
		} else {
			transform.FindChild ("BrylaDrzwi").RotateAround (transform.FindChild ("Zawiasy").position, Vector3.up, -90);
			GetComponent<AudioSource> ().Play();
			drzwiOtwarte = true;
			Debug.Log ("zamykamy");
		}

	}

}
