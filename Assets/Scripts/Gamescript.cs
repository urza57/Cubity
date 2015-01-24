using UnityEngine;
using System.Collections;

public class Gamescript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Screen.lockCursor = true;
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
		
	}
}
