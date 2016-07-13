using UnityEngine;
using System.Collections;

public class ProdukcjaJednostek : MonoBehaviour {

	// przypisujemy prefab jednostki, którą będziemy tworzyć (np Gracz2) recznie myszką
	[SerializeField] GameObject prefabJednostki = null;
	// definiujemy zmienną
	Transform miejsceNarodzin;
	int nrJednostki = 1;

	// Use this for initialization
	void Awake () {
		// inicjujemy zmienną danymi dziecka "MiejsceNarodzin"
		// nie wolno zmieniać nazwy dziecka ani jego położenia
		// Miejsce Narodzin musi być dzieckiem Domek1, a nie GlownaBryla
		miejsceNarodzin = transform.FindChild ("MiejsceNarodzin");	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject nowaJednostka = (GameObject)Instantiate (prefabJednostki,
				miejsceNarodzin.position + new Vector3 (2 * nrJednostki, 0.0f, 0.0f), Quaternion.identity);
			// inna metoda na to samo używająca przesunięcia
			// nowaJednostka.transform.Translate (new Vector3 (2 * nrJednostki, 0.0f, 0.0f));
			nrJednostki++;
		}	
	}
}
