using UnityEngine;
using System.Collections;

public class DoorOpenScript : MonoBehaviour {

	public int iDirection;
	public int startPos;
	public int maxDistance;
	Vector3 pos;
	Vector3 vel;
	
	void Update () 
	{
		if(iDirection==1)
			if(pos[0]<iDirection*maxDistance)
		{
			transform.Translate(Vector3.right * iDirection * Time.deltaTime);
			pos = transform.position;
		}
		
		if(iDirection==-1)
			if(pos[0]>iDirection*maxDistance)
		{
			transform.Translate(Vector3.right * iDirection * Time.deltaTime);
			pos = transform.position;
		}
	}
}