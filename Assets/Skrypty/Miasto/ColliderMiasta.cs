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

		panelInformacji.SetActive(true);
	}

}
