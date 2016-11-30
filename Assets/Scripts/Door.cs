using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//GetComponent<Renderer>().enabled =true; 
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider collide)
	{
		if (collide.gameObject.tag == "Player") {
			GetComponent<Renderer>().enabled =false;
		}
	}

	void OnTriggerExit(Collider collide)
	{
		if (GetComponent<Renderer> ().enabled == false) {
			GetComponent<Renderer>().enabled = true;
		}

		}
}

