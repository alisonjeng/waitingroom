using UnityEngine;
using System.Collections;
 

public class Food : MonoBehaviour {

	public AudioClip eatSound; 


	// Use this for initialization
	void Start () {




	}


	public void EatFood() {

		//gameObject.SetActive(false);

		GetComponent<Renderer>().enabled =false;

		GetComponent<AudioSource> ().PlayOneShot (eatSound);

		 
	}
}
