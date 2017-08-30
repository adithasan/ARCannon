using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour {
	public float speed = 5;
	public GameObject JoyStickController;
	// Update is called once per frame
	void Update () {
		Vector3 JoyStickInput = JoyStickController.GetComponent<SingleJoystick>().GetInputDirection();
		transform.Rotate(-JoyStickInput.y*Time.deltaTime*speed, JoyStickInput.x*Time.deltaTime*speed, 0);
	}
}
