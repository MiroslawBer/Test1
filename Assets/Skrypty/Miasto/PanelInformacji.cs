using UnityEngine;
using System.Collections;

public class PanelInformacji : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			gameObject.SetActive (false);
		}
	}
}
