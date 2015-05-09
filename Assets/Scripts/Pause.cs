using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	private bool CanPause = true;
	private GameObject go;
	public MouseLook mouseLookScript;
	public GameObject pauseText;


	void Start () {
		mouseLookScript = GetComponent<MouseLook> ();
		CanPause = true;
	}
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			if(CanPause)
			{
				Debug.Log("pause");
				Time.timeScale=0;
				CanPause = false;
				Cursor.visible = true;
				mouseLookScript.enabled = false;
				PauseAppear();
			}
			else
			{
				Debug.Log("unpause");
				Time.timeScale=1;
				CanPause=true;
				Cursor.visible = false;
				mouseLookScript.enabled = true;
				PauseDisappear();
			}
		}
	}

	void OnPauseGame() {
		CanPause = true;
	}

	void PauseDisappear() {
		GameObject obj = GameObject.Find("Paused(Clone)");
		if (obj)
			Destroy (obj.gameObject);
	}
	
	void PauseAppear() {
		Instantiate(pauseText, transform.position + transform.forward, transform.rotation);
	}

}
