using UnityEngine;
using System.Collections;

public class PickUpObject : MonoBehaviour {
	GameObject player;
	public bool carrying;
	GameObject carriedObject;
	public float distance;
	public float smooth;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("player");
	}

	void setCarry() {
		carrying = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(!carrying) {
			pickup();
		}
		if (carrying) {
			if (carriedObject == GameObject.FindWithTag("Finish")) {
				Debug.Log("Game Over");
				Application.LoadLevel(1);
			}
		}
	}
	
	void pickup() {
		if(Input.GetKeyDown (KeyCode.E)) {
			int x = Screen.width;
			int y = Screen.height;
			
			Ray ray = player.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y));
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit)) {
				PickUpable p = hit.collider.GetComponent<PickUpable>();
				if(p != null) {
					carrying = true;
					carriedObject = p.gameObject;
				}
			}
		}
	}	
}
