using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	private bool CanPause = true;
	private GameObject go;

	void Start () {
		CanPause = true;
	}
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if(CanPause)
			{
				Debug.Log("pause");
				Time.timeScale=0;
				CanPause = false;
			}
			else
			{
				Debug.Log("unpause");
				Time.timeScale=1;
				CanPause=true;
			}
		}
	}

	void OnPauseGame() {
		CanPause = true;
	}

}
