using UnityEngine;
using System.Collections;

public class obtainedKey : MonoBehaviour {

	public GameObject interrupteur;
	private GameObject player;
	public float distanceMin = 2f;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("First Person Controller");
		interrupteur.renderer.material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(player.transform.position, gameObject.transform.position);

		if(distance <= distanceMin){
			interrupteur.renderer.material.color = Color.green;
			Destroy(gameObject);
		}
	}
}