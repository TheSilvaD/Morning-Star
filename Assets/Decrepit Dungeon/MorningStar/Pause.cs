using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	private bool CanPause = true;
	private GameObject go;

	void Start () {
		CanPause = true;
	}
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			if(CanPause)
			{
				Time.timeScale=0;
				CanPause = false;
			}
			else
			{
				Time.timeScale=1;
				CanPause=true;
			}
		}
	}

	void OnPauseGame() {
		CanPause = true;
	}

}
