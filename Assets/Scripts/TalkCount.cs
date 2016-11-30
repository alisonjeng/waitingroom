using UnityEngine;
using System.Collections;

public class TalkCount : MonoBehaviour {

	void OnTriggerEnter (Collider coll) {
		if (coll.gameObject.name == "Player") {
			GameVariables.talkCount += 2;
		}
	}
}