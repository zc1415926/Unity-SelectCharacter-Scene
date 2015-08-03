using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	public string showName;

	public void onDropCharacterActivated(GameObject dropGameObject)
	{
		if(dropGameObject == gameObject)
		{
			gameObject.GetComponent<CapsuleCollider>().isTrigger = true;

		}
	}

	void OnTriggerEnter(Collider trigger)
	{
		//Debug.Log ("DropDestoryCharacter: "  + gameObject);
		if ("DestoryPlatform" == trigger.name) {
			SwitchCharacterManager manager = FindObjectOfType (typeof(SwitchCharacterManager)) as SwitchCharacterManager;
			manager.CastDestoryChatacterNameLabel(gameObject);
		}
	}
}
