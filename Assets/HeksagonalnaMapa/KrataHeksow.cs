using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KrataHeksow : MonoBehaviour {

	// http://catlikecoding.com/unity/tutorials/hex-map-1/

	[SerializeField] KomorkaHeksa prefabKomorki;
	[SerializeField] Text prefabEtykiety;

	[SerializeField] int wysokosc = 6;
	[SerializeField] int szerokosc = 6;

	KomorkaHeksa[] komorki;
	SiatkaHeksow siatka;
	Canvas canvasKraty;

	void Awake() {
		siatka = GetComponentInChildren<SiatkaHeksow> ();
		canvasKraty = GetComponentInChildren<Canvas> ();

		komorki = new KomorkaHeksa[wysokosc * szerokosc];
		for (int z = 0, i = 0; z < wysokosc; z++) {
			for (int x = 0; x < szerokosc; x++) {
				stworzKomorke (x, z, i++);
			}
		}
	}

	void Start() {
		siatka.wypelnijTrojkatami (komorki);
	}

	void Update () {
		if (Input.GetMouseButton(0)) {
			HandleInput();
		}
	}

	void HandleInput () {
		Ray inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(inputRay, out hit)) {
			TouchCell(hit.point);
		}
	}

	void TouchCell (Vector3 position) {
		position = transform.InverseTransformPoint(position);
		Debug.Log("Dotkniete pole : " + WspolrzedneHeksa.fromPosition(position));
	}

	void stworzKomorke(int x,int z, int i) {
		Vector3 pozycja;
		pozycja.x = (x + z * 0.5f - z/2) * (WymiaryHeksa.wewnetrznyPromien * 2f);
		pozycja.y = 0f;
		pozycja.z = z * (WymiaryHeksa.zewnetrznyPromien * 1.5f);
		KomorkaHeksa komorka = Instantiate<KomorkaHeksa> (prefabKomorki);
		komorka.transform.SetParent (transform, false);
		komorka.transform.localPosition = pozycja;
		komorka.Wspolrzedne = WspolrzedneHeksa.fromOffsetCoordinates (x, z);
		komorki[i] = komorka;
		stworzEtykiete (pozycja, komorka);
	}

	void stworzEtykiete(Vector3 pozycja, KomorkaHeksa komorka) {
		Text etykieta = Instantiate<Text> (prefabEtykiety);
		etykieta.rectTransform.SetParent (canvasKraty.transform, false);
		etykieta.rectTransform.anchoredPosition = new Vector2 (pozycja.x, pozycja.z);
		etykieta.text = komorka.Wspolrzedne.ToStringOddzielneLinie();
	}

}
