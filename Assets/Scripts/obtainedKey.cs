using UnityEngine;
using System.Collections;

public class obtainedKey : MonoBehaviour {

	public GameObject interrupteur;
	public GameObject player;
	public float distanceX;
	public float distanceMin = 0.7f;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("First Person Controller");
		interrupteur.renderer.material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		float xP = player.transform.position.x;
		float xC = gameObject.transform.position.x;

		if(xP >= xC)
			distanceX = xP - xC;
		else
			distanceX = xC - xP;
		if(distanceX <= distanceMin){
			interrupteur.renderer.material.color = Color.green;
			Destroy(gameObject);
		}
	}
}