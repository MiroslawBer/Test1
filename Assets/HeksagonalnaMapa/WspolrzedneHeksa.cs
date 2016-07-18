using UnityEngine;

[System.Serializable]
public struct WspolrzedneHeksa {

	[SerializeField]private int x;
	[SerializeField]private int z;

	public int X { get{ return x;} }
	public int Z { get{ return z;}}
	public int Y { get{ return -X - Z;}} // suma wszystkich wspolrzednych heksa zawsze wynosi 0;

	public WspolrzedneHeksa(int x, int z) {
		this.x = x;
		this.z = z;
	}

	public static WspolrzedneHeksa fromOffsetCoordinates(int x, int z) {
		return new WspolrzedneHeksa (x - z/2, z);
	}

	public static WspolrzedneHeksa fromPosition(Vector3 pozycja) {
		float x = pozycja.x / (WymiaryHeksa.wewnetrznyPromien * 2f);
		float y = -x;
		float offset = pozycja.z / (WymiaryHeksa.zewnetrznyPromien * 3f);
		x -= offset;
		y -= offset;

		int iX = Mathf.RoundToInt (x);
		int iY = Mathf.RoundToInt (y);
		int iZ = Mathf.RoundToInt (-x -y);

		if (iX + iY + iZ != 0) {
			float dX = Mathf.Abs (x - iX);
			float dY = Mathf.Abs (y - iY);
			float dZ = Mathf.Abs (-x -y - iZ);
			if (dX > dY && dX > dZ)
				iX = -iY - iZ;
			else
				iZ = -iX - iY;
		}

		return new WspolrzedneHeksa (iX, iZ);
	}

	public override string ToString () {
		return "(" + X.ToString () + ", " + Y.ToString() + ", " + Z.ToString () + ")";
	}

	public string ToStringOddzielneLinie () {
		return X.ToString () + "\n" + Y.ToString() + "\n" + Z.ToString ();
	}
}
