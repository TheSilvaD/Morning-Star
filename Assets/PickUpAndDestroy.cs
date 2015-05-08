using UnityEngine;
using System.Collections;

public class PickUpAndDestroy : MonoBehaviour {
	private Transform gameCharacter;
	private GameObject player;
	private PickUpObject pickUpObj;

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("player")) {
			player = GameObject.FindWithTag("player");
			pickUpObj = player.GetComponent<PickUpObject>();
			pickUpObj.carrying = true;
			Destroy(gameObject);
			Application.LoadLevel(2);

		}
	}
	
}
