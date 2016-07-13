using UnityEngine;
using System.Collections;

public class RuchKamery : MonoBehaviour {

	[SerializeField] Vector3 przesuniecieKamery = new Vector3 (20.0f, 12.0f, -20.0f);

	Transform pozycjaGracza;
	// [SerializeField] Vector3 przesuniecieKamery = Vector3.zero;
	// tworzę zmienną zainicjowaną wartościami zerowymi


	// Use this for initialization
	void Awake () {
		pozycjaGracza = GameObject.FindObjectOfType<Gracz> ().transform;
		// zamiast tego wyszukania można przypisać ręcznie w inspektorze
		// poprzez przeciągnięcie myszką trnsform Gracza 
		// [SerializeField] Transform pozycjaGracza; 
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = new Vector3 (pozycjaGracza.position.x, pozycjaGracza.position.y, pozycjaGracza.position.z) + przesuniecieKamery;

	}
}
