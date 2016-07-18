using UnityEngine;
using System.Collections;

public class KontrolerKameryDotyk : MonoBehaviour {

	[SerializeField] float predkosc = 0.1F;
	[SerializeField] float predkoscZoom = 0.5f;        // The rate of change of the field of view in perspective mode.

	void Update() {
		if (Input.touchCount == 1 && Input.GetTouch (0).phase == TouchPhase.Moved)
			ruch ();
		else if (Input.touchCount == 2)
			zoom ();


	}

	void ruch() {
		Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
		transform.Translate(-touchDeltaPosition.x * predkosc,0, -touchDeltaPosition.y * predkosc);
	}

	void zoom() {
		// Store both touches.
		Touch touchZero = Input.GetTouch(0);
		Touch touchOne = Input.GetTouch(1);

		// Find the position in the previous frame of each touch.
		Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
		Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

		// Find the magnitude of the vector (the distance) between the touches in each frame.
		float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
		float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

		// Find the difference in the distances between each frame.
		float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

		// Otherwise change the field of view based on the change in distance between the touches.
		Camera.main.fieldOfView += deltaMagnitudeDiff * predkoscZoom;

		// Clamp the field of view to make sure it's between 0 and 180.
		Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, 0.1f, 179.9f);
	}
}
