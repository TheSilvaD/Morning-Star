using UnityEngine;
using System.Collections;

public class GoToVictory : MonoBehaviour {

	void OnTriggerEnter() {
		
		Debug.Log ("Change");
		Application.LoadLevel ("victoryscene");
		
	}
	
}
