using UnityEngine;
using System.Collections;

public class ConfirmCharacterButton : MonoBehaviour {

	void OnClick(){
		SwitchCharacterManager manager = FindObjectOfType (typeof(SwitchCharacterManager)) as SwitchCharacterManager;
		manager.CastConfirmCharacter ();
	}
}
