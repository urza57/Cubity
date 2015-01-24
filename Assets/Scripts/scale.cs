using UnityEngine;
using System.Collections;

public class scale : MonoBehaviour {

	public float time;
	public GameObject player;
	public bool isOn = false;
	public bool isEnd = false;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("First Person Controller");	
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(player.transform.position, gameObject.transform.position) <= 1.85f) {
			isOn = true;
			time = 2.0f;
			isEnd = false;
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
				gameObject.renderer.enabled = false;
			}
			isEnd = true;
			}
		}
	}
