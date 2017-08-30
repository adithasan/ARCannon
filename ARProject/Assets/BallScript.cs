using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public GameObject GeneralObject;
	public GameObject Explosion;
	public GameObject Marker;

	void Start(){
		GeneralObject = GameObject.Find("Canvas");
		Marker = GameObject.Find("Canvas");
		Destroy(gameObject, 5);
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.CompareTag("Enemy")){
			GameObject clone;
			clone = Instantiate(Explosion, other.transform.position, other.transform.rotation, Marker.transform);
			Destroy(clone, 1.5f);
			Destroy(other.gameObject);
			GeneralObject.GetComponent<GeneralScript>().score ++;

		}
	}
}
