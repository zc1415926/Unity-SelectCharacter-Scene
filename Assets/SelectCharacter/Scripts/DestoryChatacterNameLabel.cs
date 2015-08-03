using UnityEngine;
using System.Collections;

public class DestoryChatacterNameLabel : MonoBehaviour {

	public void onDestoryChatacterNameLabel(GameObject nameLabelOwner)
	{
		//Debug.Log ("onDestoryChatacterNameLabel");
		/*if (gameObject.GetComponent<dfFollowObject> ().attach == nameLabelOwner) {
			Destroy(gameObject);
		}*/

		dfFollowObject[] followsOfNameLabel = gameObject.GetComponentsInChildren<dfFollowObject> ();
		foreach (dfFollowObject follow in followsOfNameLabel) {
			if(follow.attach == nameLabelOwner){
				Destroy(follow.gameObject);
				Destroy(nameLabelOwner);
			}
		}
	}
}
