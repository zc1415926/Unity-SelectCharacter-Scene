using UnityEngine;
using System.Collections;

public class SwitchCharacterManager : MonoBehaviour {

	//public GameObject[] 
	public GameObject[] characters;

	public delegate void SwitchCharacterEventHandler(GameObject character);
	public event SwitchCharacterEventHandler InstantiateCharacterActivated;
	public event SwitchCharacterEventHandler DropCharacterActivated;
	//public delegate int DestoryGameObject();
	public event SwitchCharacterEventHandler DeleteNameLabel;


	private int currentNumOfCharacter = -1;
	private GameObject currentGameObject;
	private GameObject dropGameObject;


	void Start()
	{
		if (characters.Length != 0) {
			CastSwitchCharacter(true);
		} else {
			Debug.LogError("You have no character to be instantiate!");
		}


	}

	//direction false then switch backward, true switch forward
	public void CastSwitchCharacter(bool direction)
	{
		//the if...else block determine the index of character to be instantiate
		if (direction) 
		{
			if(currentNumOfCharacter == characters.Length-1)
			{
				currentNumOfCharacter = 0;
			}
			else
			{
				currentNumOfCharacter++;
			}
		} 
		else 
		{
			if(currentNumOfCharacter == 0)
			{
				currentNumOfCharacter = characters.Length-1;
			}
			else
			{
				currentNumOfCharacter--;
			}
		}

		dropGameObject = currentGameObject;
		currentGameObject = Instantiate(characters[currentNumOfCharacter]);
		currentGameObject.name = characters [currentNumOfCharacter].name;
		currentGameObject.GetComponent<dfEventBinding> ().DataSource.Component = gameObject.GetComponent<SwitchCharacterManager> ();
		InstantiateCharacterActivated(currentGameObject);

		if (DropCharacterActivated != null) {
			//Debug.Log ("DropCharacterActivated:" + DropCharacterActivated);
			DropCharacterActivated (dropGameObject);
		}
//		DropCharacterActivated (new GameObject());
		//Debug.Log (DropCharacterActivated);
		//Debug.Log (DeleteNameLabel);
	}

	public void CastDestoryChatacterNameLabel(GameObject nameLabelOwner)
	{
//		Debug.Log ("nameLabelOwner:" + nameLabelOwner);
		//DestoryChatacterNameLabelActivated ();
		DeleteNameLabel (nameLabelOwner);
	}

	public void CastConfirmCharacter()
	{
		PlayerPrefs.SetString ("SelectedCharacter",currentGameObject.name);
		Debug.Log( PlayerPrefs.GetString ("SelectedCharacter"));
	}
	
}