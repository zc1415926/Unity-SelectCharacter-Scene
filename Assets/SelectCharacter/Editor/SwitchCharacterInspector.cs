using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(SwitchCharacter))]
public class SwitchCharacterInspector : Editor {

	public override void OnInspectorGUI()
	{
		var control = target as SwitchCharacter;

		string[] switchTo = {"Backward", "Forward"};

		//control.Switch is a bool. so, if it's false then assigned with second parameter
		var assignedIndex = control.SwitchTo ? 1 : 0;
		var index = EditorGUILayout.Popup("Switch To", assignedIndex, switchTo);

		if(index != assignedIndex)
		{
			control.SwitchTo = index == 0 ? false : true;
		}
	}
}
