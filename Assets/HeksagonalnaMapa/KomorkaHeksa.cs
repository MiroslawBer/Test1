using UnityEngine;
using System.Collections;

public class KomorkaHeksa : MonoBehaviour {

	[SerializeField] WspolrzedneHeksa wspolrzedne;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public WspolrzedneHeksa Wspolrzedne {
		get{ return wspolrzedne;}
		set{ wspolrzedne = value;}
	}
}
