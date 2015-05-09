using UnityEngine;
using System.Collections;

public class GoToMenu : MonoBehaviour {

	private bool isReady = false;

	// Use this for initialization
	void Start () {
		isReady = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if(isReady)
			{
				Application.LoadLevel("menu");
			}
		}
	}
}
