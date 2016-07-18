using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(WspolrzedneHeksa))]
public class WspolrzedneHeksaSzuflada : PropertyDrawer {


	public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
	{
		WspolrzedneHeksa wspolrzedne = new WspolrzedneHeksa (
			                               property.FindPropertyRelative ("x").intValue,
			                               property.FindPropertyRelative ("z").intValue
		                               );
		position = EditorGUI.PrefixLabel (position, label);
		GUI.Label (position, wspolrzedne.ToString ());
	}
}
