using UnityEngine;
using System.Collections;

public class OtwieranieDrzwi : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Physics.queriesHitTriggers = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		Debug.Log ("pukamy");
	}



}
