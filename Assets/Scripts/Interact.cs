using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class Interact : MonoBehaviour {

	public string interactButton; 

	public float interactDistance = 7f;
	public LayerMask interactLayer; //Filter

	public Image interactIcon; //picture of hand for interaction 

	public bool isInteracting; 

	//GameObject mainCamera; 

	// Use this for initialization
	void Start () {

		//mainCamera = GameObject.FindWithTag("MainCamera");


		//Set interact icon to be invisible 
		if (interactIcon != null) {
			interactIcon.enabled = false;

		}
	}
	
	// Update is called once per frame
	void Update () {
		//Ray ray = new Ray (transform.position, transform.forward);
		//Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		//RaycastHit hit; 

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;


		/*int x = Screen.width / 2;
		int y = Screen.height / 2;

		Ray ray = Camera.main.ScreenPointToRay (new Vector3 (x, y)); 
		RaycastHit hit;*/

		//Shoots a ray
		//if (Physics.Raycast (ray, out hit, interactDistance, interactLayer)) {

		if (Physics.Raycast (ray, out hit, 5, interactLayer)) {

			//Checks if interacting
			if (isInteracting == false) {

				if (interactIcon != null) {
			
					interactIcon.enabled = true; 


				}
				if (Input.GetButtonDown (interactButton)) {

					//If it is a note
					if (hit.collider.CompareTag ("Note")) {
					
						hit.collider.GetComponent<Note> ().ShowNoteImage (); 
					} 
					else if (hit.collider.CompareTag ("food")) {
						hit.collider.GetComponent<Food> ().EatFood ();

			
					
					}
				
				
				}
					
			}
		}

				else {
		
					interactIcon.enabled = false; 
		
		
				}
	
			}
		}
	


