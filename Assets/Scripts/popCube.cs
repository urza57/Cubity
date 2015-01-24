using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class popCube : MonoBehaviour {

	public List<GameObject> cubeList;
	public GameObject player;
	public bool isOn = false;
	public bool isEnd = false;
	public float time;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("First Person Controller");
	}
	
	// Update is called once per frame
	void Update() {
		if(Vector3.Distance(player.transform.position, gameObject.transform.position) <= 1.85f) {
			isOn = true;
			time = 2.0f;
			isEnd = false;
			foreach(GameObject cube in cubeList){
				cube.renderer.enabled = true;
			}
			gameObject.renderer.enabled = true;
		}
		else if(!isEnd) {
			if(isOn) {
				time = 2.0f;
				isOn = false;
			}
			else {
				time -= Time.deltaTime;
			}
			if(time <= 0){
				foreach(GameObject cube in cubeList){
					cube.renderer.enabled = false;
					//cube.renderer.material.color = Color.red;
				}
				gameObject.renderer.enabled = false;
				isEnd = true;
			}
		}
	}

	/*void OnDrawGizmos() {
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(transform.position, 1.8f);
	}*/
}