using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFlip : MonoBehaviour {

	private float rotationY = 0f;
	private float sensitivityY = 2f;

	private float rotationX = 0f;
	private float sensitivityX = 2f;

	public bool cannon;
	public bool body;

	float startx;

	void Start(){
		startx = transform.localEulerAngles.x;
	}
	// Update is called once per frame
	void Update () {
		Movement ();
	}

	void Movement(){
		if (body) {
			rotationY += Input.GetAxis ("Horizontal") * sensitivityY;
			rotationY = Mathf.Clamp (rotationY, -45f, 45f);//coge el valor y te da el min y el max
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, rotationY, transform.eulerAngles.z);
		}

		if (cannon) {

			rotationX += Input.GetAxis ("Vertical") * sensitivityX;
			rotationX = Mathf.Clamp (rotationX, startx, startx+20f);//coge el valor y te da el min y el max
			transform.localEulerAngles = new Vector3 (rotationX, transform.localEulerAngles.y, transform.localEulerAngles.z);
		}

		Debug.Log (startx);


	}

}
