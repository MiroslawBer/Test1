using UnityEngine;
using System.Collections;

public class KontrolerKameryPC : MonoBehaviour {

	[SerializeField] float predkosc = 0.2F;
	[SerializeField] float predkoscZoom = 20f;

	void Update() {
		if (Input.GetKey(KeyCode.UpArrow))
			transform.Translate(Vector3.forward * predkosc);
		if (Input.GetKey(KeyCode.DownArrow))
			transform.Translate(Vector3.back * predkosc);
		if (Input.GetKey(KeyCode.LeftArrow))
			transform.Translate(Vector3.left * predkosc);
		if (Input.GetKey(KeyCode.RightArrow))
			transform.Translate(Vector3.right * predkosc);

		float fov = Camera.main.fieldOfView;
		fov += -Input.GetAxis("Mouse ScrollWheel") * predkoscZoom;
		fov = Mathf.Clamp(fov, 0.1f, 179.9f);
		Camera.main.fieldOfView = fov;
	}
}
