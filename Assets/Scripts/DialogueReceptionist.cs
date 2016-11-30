using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class DialogueReceptionist : MonoBehaviour {

	public Image dialogueImage1; 
	public Image dialogueImage2; 


	// Use this for initialization
	void Start () {

		dialogueImage1.enabled =true; 
		dialogueImage2.enabled = false; 

	}


	/*public void ShowDialogue() {

		dialogueImage.enabled = true; 

	}*/

	/*public void HideDialogue() {

	dialogueImage.enabled = false;
}*/

void OnTriggerEnter(Collider coll)
{
	if (coll.gameObject.tag == "Player") {
		dialogueImage1.enabled = false; 
		GameVariables.talkCount += 1; 
	}

	if (coll.gameObject.tag == "Player" && GameVariables.talkCount >=1) {
			dialogueImage2.enabled = true; 
		}

}

void OnTriggerExit(Collider coll)
{
	/*if (dialogueImage1.enabled == true) {
		dialogueImage1.enabled = false; 
	}*/

	if (dialogueImage2.enabled == true) {
			dialogueImage2.enabled = false;
	
	}
}
}