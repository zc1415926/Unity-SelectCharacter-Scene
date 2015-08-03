using UnityEngine;
using System.Collections;

public class SwitchCharacterNameLabel : MonoBehaviour {

	//public Camera cam;
	public GameObject characterNamePrefab;

	public void onInstantiateCharacterActivated(GameObject character)
	{

		GameObject characterName = Instantiate (characterNamePrefab);
		characterName.transform.parent = gameObject.transform;
		characterName.GetComponent<dfLabel> ().Text = character.GetComponent<Character> ().showName;

		dfFollowObject characterNameFollow = characterName.GetComponent<dfFollowObject> ();
		characterNameFollow.attach = character;
		characterNameFollow.enabled = true;


		//characterName.GetComponent<dfEventBinding> ().DataSource.Component = FindObjectOfType (typeof(SwitchCharacterManager)) as SwitchCharacterManager;

		//characterName.GetComponent<dfEventBinding> ().Bind ();
		//characterName.GetComponent<dfEventBinding> ().AutoBind = true;

		//Debug.Log ("isActiveAndEnabled: " + characterName.GetComponent<dfEventBinding> ().isActiveAndEnabled);

	}
}
