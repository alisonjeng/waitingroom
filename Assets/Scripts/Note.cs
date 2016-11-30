using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Note : MonoBehaviour {

	public Image noteImage; 
	//public GameObject hideNoteButton; 
	//public GameObject playerObject;

	public AudioClip pickupSound; 
	public AudioClip putawaySound; 

	// Use this for initialization
	void Start () {
	
		noteImage.enabled = false; 
		//hideNoteButton.SetActive (false);


	}


	public void ShowNoteImage() {

		noteImage.enabled = true; 
		GetComponent<AudioSource> ().PlayOneShot (pickupSound);
	
		//hideNoteButton.SetActive (true); 

		//Disable player controller
		//playerObject.GetComponent<MouseLook>().enabled = false; 

		//Unlock the mouse cursor
		//Cursor.lockState = CursorLockMode.None;
		//Cursor.visible = true; 
	}

	public void HideNoteImage() {

		noteImage.enabled = false;
		//hideNoteButton.SetActive (false); 
		GetComponent<AudioSource> ().PlayOneShot (putawaySound);


		//Disable player controller
		//playerObject.GetComponent<MouseLook>().enabled = true;  

		//Unlock the mouse cursor
		//Cursor.lockState = CursorLockMode.Locked;
		//Cursor.visible = false; 
	
	
	}

	void Update(){
	if (Input.GetKeyDown ("r")) {

			HideNoteImage();
		
}
	}
}
