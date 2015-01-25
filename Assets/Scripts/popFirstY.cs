using UnityEngine;
using System.Collections;

public class popFirstY : MonoBehaviour {
	
	public GameObject player;
	public bool isEnabled = false;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("First Person Controller");
		gameObject.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(!isEnabled && Vector3.Distance(player.transform.position, gameObject.transform.position) <= 1.85f) {
			gameObject.renderer.enabled = true;
			isEnabled = true;
		}
	}
}