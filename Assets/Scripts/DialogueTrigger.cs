using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class DialogueTrigger : MonoBehaviour {

	public Image dialogueImage1; 


	void OnTriggerEnter(Collider collid)
	{
		if (collid.gameObject.tag == "Player") {
			dialogueImage1.enabled = false; 

}
	}
}