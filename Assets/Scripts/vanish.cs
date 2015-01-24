using UnityEngine;
using System.Collections;

public class vanish : MonoBehaviour {

	private BoxCollider box;
	public float time;
	public GameObject player;
	public bool isOn = false;
	public bool isEnd;
	public bool shown = true;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("First Person Controller");
		box = GetComponent<BoxCollider>();	
		isEnd = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(isEnd) {
			if (Vector3.Distance(player.transform.position, gameObject.transform.position) <= 1.85f)
			{
				isOn = true;
				time = 1.5f;
				isEnd = false;
			}
		}
		else if(!isEnd) {	
			if(isOn) {
				time = 1.5f;
				isOn = false;
			}
			else {
				time -= Time.deltaTime;
			}

			if(time <= 0){
				// Disappear
				box.enabled = false;
				gameObject.renderer.enabled = false;

				isEnd = true;
				shown = false;
			}
		}
		if (!shown) {
			if (time <= -1.5f) {
				// Reappear
				box.enabled = true;
				gameObject.renderer.enabled = true;
				shown = true;
			}
			else {
				time -= Time.deltaTime;
			}
		}
	}
}
