using UnityEngine;
using System.Collections;


public class GameManager : MonoBehaviour {

	public GameObject Startpage; 
	public GameObject Player;
	//public GameObject Endpage;



	public enum GameManagerState
	{
		Start,
		Play,
		//End,

	}

	GameManagerState GMState; 


	// Use this for initialization
	void Start() {
		//Endpage.SetActive (false); 
		Player.SetActive (false);
		Startpage.SetActive (true); 
		GMState = GameManagerState.Start;


	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("s")) {
			GetComponent<GameManager> ().SetGameManagerState (GameManager.GameManagerState.Play); 

		}

	}

	void UpdateGameManagerState() {
		switch (GMState) {

		case GameManagerState.Start:
			
			//Endpage.SetActive (false); 
			Startpage.SetActive(true);
			Player.SetActive (false); 
			break; 

		case GameManagerState.Play:
			Startpage.SetActive (false);
			Player.SetActive (true); 
			break; 

		//case GameManagerState.End:
			//Startpage.SetActive (false); 
			//Player.SetActive (false); 
			//Endpage.SetActive (true); 
			 



			//Change game manager to opening state after 8 seconds 
			//Invoke ("ChangeToStartState", 8f); 


			//break; 

		/*case GameManagerState.Escaped:
			Startpage.SetActive (false);
			Player.SetActive (false); 

			break; 

*/
		}


	}

	public void SetGameManagerState (GameManagerState state) {
		GMState = state; 
		UpdateGameManagerState ();

	}

	public void StartGamePlay() {
		UpdateGameManagerState ();

	}

	//Function to change game to opening state
	public void ChangeToStartState() {

		SetGameManagerState (GameManagerState.Start); 

	}

}

