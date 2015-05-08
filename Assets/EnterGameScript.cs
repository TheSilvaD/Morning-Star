using UnityEngine;
using System.Collections;

public class EnterGameScript : MonoBehaviour {

	private bool isReady = false;

	// Use this for initialization
	void Start () {
		isReady = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) {
			if(isReady)
			{
				Application.LoadLevel("morningstarscene");
			}
		}
	}
}
