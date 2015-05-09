using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	private bool CanPause = true;
	private GameObject go;
	public MouseLook mouseLookScript;
	//public Light flashLight;
	//public FlashLight flashLightScript;


	void Start () {
		mouseLookScript = GetComponent<MouseLook> ();
		//flashLight = GetComponentInChildren<Light> ();
		//flashLightScript = GetComponentInChildren<FlashLight> ();
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
				//flashLight.enabled = false;
				//flashLightScript.enabled = false;
			}
			else
			{
				Debug.Log("unpause");
				Time.timeScale=1;
				CanPause=true;
				Cursor.visible = false;
				mouseLookScript.enabled = true;
				//flashLight.enabled = true;
				//flashLightScript.enabled = true;
			}
		}
	}

	void OnPauseGame() {
		CanPause = true;
	}

}
