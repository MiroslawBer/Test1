using UnityEngine;
using System.Collections;

public class ColliderGraczaMaRuch : MonoBehaviour {

	[SerializeField] float skokGracza = 0f;
	// ręcznie wstawiam połączenie z Miasto1
	[SerializeField] GameObject miasto1 = null;
	[SerializeField] Material materialZaznaczony;
	[SerializeField] Material materialNieZaznaczony;
	bool czyZaznaczony = false;
	[SerializeField] Vector3 pozycjaPoSkoku;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1) && czyZaznaczony == true) {
		//if (Input.GetMouseButtonDown(1)) {
		//	transform.parent.position = new Vector3 (Came  Camera .main.ScreenToWorldPoint (Input.mousePosition));

			GetComponent<MeshRenderer> ().material = materialNieZaznaczony;
			czyZaznaczony = false;
	
			//bool trafionoObiekt = false;
			//GameObject obiekt;
			Ray promien = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit trafienie = new RaycastHit();
		
			Physics.Raycast (promien, out trafienie);
			// trafionoObiekt = Physics.Raycast (promien, out trafienie);
			//if(trafionoObiekt)
			//{
			
				//Physics.Raycast (promien, out );
				//trafienie.point
			//	obiekt = trafienie.transform.gameObject;
			//	Debug.Log("Kliknieto : "+obiekt.name);
				Debug.Log("Kliknieto punkt : "+trafienie.point);
				//trafienie.collider.renderer.materialNieZaznaczony.color = Color.red;
			//}
			//transform.parent.position = trafienie.point + new Vector3 (-10f, 10f, 0f);
			transform.parent.position = trafienie.point + pozycjaPoSkoku;
		}
	
			
	}


	void OnMouseDown(){

		// niniejsza procedura musi być w obiekcie gdzie jest collider, nie w dziecku

		//transform.parent.Translate (new Vector3 (skokGracza, 0, 0));
		//transform.parent.position = miasto1.transform.position + new Vector3 (skokGracza, 10f, 0f);
		if (czyZaznaczony == false) {
			Debug.Log ("Zaznaczony");
			GetComponent<MeshRenderer> ().material = materialZaznaczony;
			czyZaznaczony = true;
		} else {
			Debug.Log ("Niezaznaczony");
			GetComponent<MeshRenderer> ().material = materialNieZaznaczony;
			czyZaznaczony = false;
		}



	}

}
