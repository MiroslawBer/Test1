using UnityEngine;
using System.Collections;

public class GeneratorPodloza : MonoBehaviour {

	[SerializeField] Transform podloze;
	[SerializeField] GameObject[] listaPol;

	// Use this for initialization
	void Start () {
		generujPodloze (15, 15);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void generujPodloze(int szer, int wys) {
		
		int x = -szer / 2;
		int z = -wys / 2;
		Vector3 pozycjaNowegoPola = new Vector3 (x, 0, z);
		for (int i = 0; i < szer; i++) {
			for (int j = 0; j < wys; j++) {
				GameObject pole = (GameObject)Instantiate (listaPol [Random.Range (0, listaPol.Length)], pozycjaNowegoPola, Quaternion.identity);
				pole.transform.Rotate (new Vector3 (90, 0, 0));
				pole.transform.SetParent (podloze);
				pozycjaNowegoPola.x = x + i;
				pozycjaNowegoPola.z = z + j;
			}
		}
	}
}
