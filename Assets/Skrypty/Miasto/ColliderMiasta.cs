using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColliderMiasta : MonoBehaviour {

	// ręcznie przypidujemy referencje do PanelInformacji w scenie
	[SerializeField] GameObject panelInformacji = null;


	// Use this for initialization
	void Awake () {
		// panelInformacji = GameObject.Find("PanelInformacji");
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		// wyświetli ColliderMiasta, bo jest w tym obiekcie (skrypt jest obiektem - komponentem)
		// Debug.Log (gameObject.name);
		// 
		//Debug.Log (transform.parent.gameObject.name);

		panelInformacji.transform.FindChild ("NazwaElementu").GetComponent<Text> ().text = transform.parent.GetComponent<Miasto> ().NazwaMiasta;

		// stara wersja 
		//if (transform.parent.gameObject.name == "Miasto") {
			//transform.parent.GetComponent<Miasto>().
			//GetComponent<AudioSource> ().Play();
		//	panelInformacji.transform.FindChild ("NazwaElementu").GetComponent<Text> ().text = "Warszawa";

		//} else if (transform.parent.gameObject.name == "Miasto2") {
		//	panelInformacji.transform.FindChild ("NazwaElementu").GetComponent<Text> ().text = "Wrocław";
		//}
			
		panelInformacji.SetActive(true);
		
	}

}
