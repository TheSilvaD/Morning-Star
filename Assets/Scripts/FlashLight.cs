using UnityEngine;
using System.Collections;

public class FlashLight : MonoBehaviour 
{
	Light flashlight;
	bool on = false;
	public float decaySpeed = .0002f;

	void Start()
	{
		flashlight = GetComponentInChildren<Light>();
	}
	
	void Update()
	{
		if (flashlight.GetComponent<Light>().intensity == 0)
			Application.LoadLevel(3);
		if(on) {
			flashlight.GetComponent<Light>().enabled = true;
			if (Time.timeScale !=0)
				flashlight.GetComponent<Light>().intensity -= decaySpeed;
		}
		else if(!on)
			flashlight.GetComponent<Light>().enabled = false;
		if(Input.GetKeyDown(KeyCode.F))
			on = !on;
	}
}