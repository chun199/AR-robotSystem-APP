using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public void OnStarARSystem(string scenename){
		Application.LoadLevel(scenename);
	}
}