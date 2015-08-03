using UnityEngine;
using System.Collections;

public class SwitchCharacter : MonoBehaviour {

	public SwitchCharacterManager manager;


	//if false switch backward, or true switch forward
	[SerializeField]
	private bool boolSwitchTo;



	public bool SwitchTo
	{
		get{ return this.boolSwitchTo; }
		set{ this.boolSwitchTo = value; }
	}

	void OnClick()
	{
		SwitchCharacterManager manager = FindObjectOfType (typeof(SwitchCharacterManager)) as SwitchCharacterManager;
		if(manager != null)
		{
			manager.CastSwitchCharacter(SwitchTo);
		}
	}


}
