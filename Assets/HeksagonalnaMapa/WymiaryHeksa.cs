using UnityEngine;

public static class WymiaryHeksa {

	public const float wewnetrznyPromien = 10.0f;
	public const float zewnetrznyPromien = wewnetrznyPromien * 0.866025404f;

	public static Vector3[] rogi = {
		new Vector3(0f, 0f, zewnetrznyPromien),
		new Vector3(wewnetrznyPromien, 0f, 0.5f * zewnetrznyPromien),
		new Vector3(wewnetrznyPromien, 0f, -0.5f * zewnetrznyPromien),
		new Vector3(0f, 0f, -zewnetrznyPromien),
		new Vector3(-wewnetrznyPromien, 0f, -0.5f * zewnetrznyPromien),
		new Vector3(-wewnetrznyPromien, 0f, 0.5f * zewnetrznyPromien),
		new Vector3(0f, 0f, zewnetrznyPromien) // siodmy rog heksa dodany dla latwiejszej obslugi petli tworzacej trojkaty
	};
}
