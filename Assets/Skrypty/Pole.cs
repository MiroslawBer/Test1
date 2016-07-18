using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pole : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseOver()
	{
		GameObject.Find ("Text").GetComponent<Text> ().text = gameObject.name;
	}
}
