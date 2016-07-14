using UnityEngine;
using System.Collections;

public class Miasto : MonoBehaviour {

	[SerializeField] string nazwaMiasta = "";

	// Use this for initialization
	void Awake () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Property
	public string NazwaMiasta {
		get { return nazwaMiasta; }
	}

}
