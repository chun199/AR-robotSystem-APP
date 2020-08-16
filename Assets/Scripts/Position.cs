using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Position : MonoBehaviour {
	
	//float Position1;
	public GameObject Model1;
	public Text Xposition;
	public Text Yposition;
	public Text Zposition;

	
	
	// Update is called once per frame
	void Update () {
		float x = Model1.transform .position .x;
		float y = Model1.transform .position .y;
		float z = Model1.transform .position .z;
		
		Xposition.text = ""+x;
		Yposition.text = ""+y;
		Zposition.text = ""+z;
	}
}
