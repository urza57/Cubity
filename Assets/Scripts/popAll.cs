using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class popAll : MonoBehaviour {
	
	public List<GameObject> cubeList;
	public GameObject player;
	public bool isOn = false;
	public bool isEnd = false;
	public float time;
	
	// Use this for initialization
	void Start () {
		player = GameObject.Find("First Person Controller");
		foreach(GameObject cube in cubeList){
			cube.renderer.enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update() {
		if(Vector3.Distance(player.transform.position, gameObject.transform.position) <= 1.85f) {
			foreach(GameObject cube in cubeList){
				cube.renderer.enabled = true;
			}
			gameObject.renderer.enabled = true;
		}
	}
}