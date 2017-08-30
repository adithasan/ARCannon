using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileScript : MonoBehaviour {
	public Rigidbody projectile;
	public GameObject FireScriptObject;
	public GameObject Marker;
	public Slider PowerSlider;
	public void FireCannon(){
		Rigidbody clone;
		float power = Mathf.Lerp(100f, 2500f, PowerSlider.value);
		Debug.Log(power);
		clone = Instantiate(projectile, transform.position, transform.rotation, Marker.transform) as Rigidbody;
		clone.AddForce(transform.forward*power);
	}
}
