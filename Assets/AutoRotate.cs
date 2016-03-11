using UnityEngine;
using System.Collections;

public class AutoRotate : MonoBehaviour {
	Quaternion rotationTo;
	// Use this for initialization
	void Start () {
		rotationTo = Random.rotationUniform;
	}
	
	// Update is called once per frame
	void Update () 
	{

		this.transform.RotateAround (transform.position, new Vector3(5f,10f, 1f),1f);

//		//this.transform.rotation = Quaternion.Slerp (this.transform.rotation,rotationTo,1f*Time.deltaTime);
//		this.transform.rotation = Quaternion.Lerp (this.transform.rotation, rotationTo, Time.deltaTime);
//		//yield return new WaitForEndOfFrame();
//		if(Quaternion.Angle(this.transform.rotation,rotationTo) <= 15.0f)
//		{
//			rotationTo = Random.rotationUniform;
//		}

	}
}
