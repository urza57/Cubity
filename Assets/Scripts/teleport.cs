using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {

	public GameObject tp;
	private GameObject player;

	void Start()
	{
		player = GameObject.Find("First Person Controller");
	}

	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(this.transform.position, player.transform.position) < 2.0f)
		{
			player.transform.position = tp.transform.position;
		}
	}
}
