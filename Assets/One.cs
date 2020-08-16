using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class One : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.tag == "obstacle")
		{
			//Destroy(collision.gameObject);
			collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
		}
	}
	void OnTriggerExit(Collider collider){
		if (collider.gameObject.tag == "obstacle")
		{
			//Destroy(collision.gameObject);
			collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
		}
	}
}
