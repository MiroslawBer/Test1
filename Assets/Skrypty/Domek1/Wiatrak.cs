using UnityEngine;
using System.Collections;

public class Wiatrak : MonoBehaviour {

	[SerializeField]int jednorazowyObrot = 1;
	[SerializeField]float czasMiedzyObrotami = 0.3f;
	float czasOstatniegoObrotu = 0.0f;
	Transform glowica = null;

	void Awake () {
		glowica = transform.FindChild ("Glowica");
	}

	void Update () {
		if (Time.timeSinceLevelLoad > czasOstatniegoObrotu + czasMiedzyObrotami) {
			glowica.RotateAround (glowica.position, Vector3.right, jednorazowyObrot);
			czasOstatniegoObrotu = Time.timeSinceLevelLoad;
		}
	}
}
