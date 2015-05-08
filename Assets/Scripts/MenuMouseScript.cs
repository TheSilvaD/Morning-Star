using UnityEngine;
using System.Collections;

public class MenuMouseScript : MonoBehaviour {

	void OnMouseDown()
	{
		// if we clicked the play button
		if (this.name == "PlayButton")
		{
			// load the game
			Application.LoadLevel("MorningStarScene");
		}
	}
}
