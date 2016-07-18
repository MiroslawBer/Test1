using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class SiatkaHeksow : MonoBehaviour {

	Mesh siatka;
	MeshCollider collider;
	List<Vector3> wierzcholki;
	List<int> trojkaty;

	void Awake () {
		siatka = new Mesh();
		GetComponent<MeshFilter> ().mesh = siatka;
		siatka.name = "Model siatki";
		collider = gameObject.AddComponent<MeshCollider> ();

		wierzcholki = new List<Vector3>();
		trojkaty = new List<int>();
	}


	public void wypelnijTrojkatami(KomorkaHeksa[] komorki) {
		siatka.Clear ();
		wierzcholki.Clear ();
		trojkaty.Clear ();
		for (int i = 0; i < komorki.Length; i++) {
			wypelnijKomorkeTrojkatami (komorki [i]);
		}
		siatka.vertices = wierzcholki.ToArray ();
		siatka.triangles = trojkaty.ToArray ();
		siatka.RecalculateNormals ();
		collider.sharedMesh = siatka;
	}

	void wypelnijKomorkeTrojkatami(KomorkaHeksa komorka) {
		Vector3 srodek = komorka.transform.localPosition;
		for (int i = 0; i < 6; i++) {
			dodajTrojkat (srodek, srodek + WymiaryHeksa.rogi [i], srodek+ WymiaryHeksa.rogi [i+1]);
		}
	}

	void dodajTrojkat(Vector3 v1,Vector3 v2, Vector3 v3) {
		int indeksWierzcholka = wierzcholki.Count;
		wierzcholki.Add (v1);
		wierzcholki.Add (v2);
		wierzcholki.Add (v3);
		trojkaty.Add (indeksWierzcholka);
		trojkaty.Add (indeksWierzcholka + 1);
		trojkaty.Add (indeksWierzcholka + 2);
	}
}
