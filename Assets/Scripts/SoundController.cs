using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundController : MonoBehaviour {

	public GameObject[] points;
	public GameObject[] level;
	private GameObject player;
	private int currentPos = 0;
	private float t = 0;
	public float duration = 3;
	private bool playerArrived = false;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.Find("First Person Controller");
		foreach(GameObject obj in points)
		{
			obj.audio.Stop();
		}
		points[currentPos].audio.Play();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Vector3.Distance(this.player.transform.position, transform.position) < 20.0)
		{
			playerArrived = true;
		}
		if (playerArrived)
		{
			foreach(GameObject lvl in level)
			{
				lvl.renderer.material.color = Color.Lerp(Color.white, Color.black, t);
			}
			if (t < 1)
			{
				t += Time.deltaTime/duration;
			}
		}
		if (currentPos < points.Length)
		{
			if (Vector3.Distance(this.player.transform.position, points[currentPos].transform.position) < 2.0)
			{
				points[currentPos].audio.Stop();
				currentPos++;
				Debug.Log("Next pos" + currentPos);
				if (currentPos < points.Length)
				{
					points[currentPos].audio.Play();
				}
			}
		}
	}

	void OnDrawGizmosSelected() {
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireCube(transform.position, new Vector3(10, 10, 10));
	}
}
