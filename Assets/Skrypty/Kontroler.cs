using UnityEngine;
using System.Collections;

public class Kontroler : MonoBehaviour {
	//http://answers.unity3d.com/questions/359754/how-can-i-detect-touch-on-anroid-or-iphone.html

	[SerializeField] bool wykrywanieMyszki = true;
	[SerializeField] bool wykrywanieDotyku = false;

	// Update is called once per frame
	void Update(){
		if(wykrywanieMyszki)
			obslugaMyszki ();	
		if(wykrywanieDotyku)
			obslugaDotyku ();
	}

	void obslugaMyszki() {
		if(Input.GetMouseButtonDown(0))
		{    
			bool trafionoObiekt = false;
			GameObject obiekt;
			Ray promien = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit trafienie = new RaycastHit();
			trafionoObiekt = Physics.Raycast (promien, out trafienie);
			if(trafionoObiekt)
			{
				obiekt = trafienie.transform.gameObject;
				Debug.Log("Kliknieto : "+obiekt.name);
				obslugaTrafionegoObiektu (obiekt);
			}
		}
	}
	void obslugaDotyku() {
		if(Input.touchCount > 0) // == 1
		{    
			bool trafionoObiekt = false;
			GameObject obiekt;
			// touch on screen
			if(Input.GetTouch(0).phase == TouchPhase.Began)
			{
				Ray promien = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
				RaycastHit trafienie = new RaycastHit();
				trafionoObiekt = Physics.Raycast (promien, out trafienie);
				if(trafionoObiekt)
				{
					obiekt = trafienie.transform.gameObject;
					Debug.Log("Dotknieto : "+obiekt.name);
					obslugaTrafionegoObiektu (obiekt);
				}

			}


			// release touch/dragging
			/*if((Input.GetTouch(0).phase == TouchPhase.Ended || Input.GetTouch(0).phase == TouchPhase.Canceled) && go != null)
			{
				moving = false;
				Debug.Log("Touch Released from : "+go.name);
			}*/
		}
	}

	// metoda do testow
	void obslugaTrafionegoObiektu(GameObject obiekt) {

		if (obiekt.tag == "Pole") {
			GameObject.Find ("Jednostka").GetComponent<RuchJednostki> ().przesunNaPozycje (obiekt.transform.position);
		} 
	}
}
