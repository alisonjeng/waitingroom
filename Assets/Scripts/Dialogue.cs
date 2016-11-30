using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class Dialogue : MonoBehaviour {

	public Image dialogueImage; 

	// Use this for initialization
	void Start () {
		
		dialogueImage.enabled = false; 
	
	}


	/*public void ShowDialogue() {

		dialogueImage.enabled = true; 

	}*/

	/*public void HideDialogue() {

		dialogueImage.enabled = false;
	}*/

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			dialogueImage.enabled = true; 
		} 
			 
	}

	void OnTriggerExit(Collider col)
	{
		if (dialogueImage.enabled == true) {
			dialogueImage.enabled = false; 
		}
	}
		


	// Update is called once per frame
	void Update () {
	
	}
}
