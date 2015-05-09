using UnityEngine;
using System.Collections;

public class GoToNextLevel : MonoBehaviour {
	
	void OnTriggerEnter() {

			Debug.Log ("Change");
			Application.LoadLevel ("creditscene");

	}

}
