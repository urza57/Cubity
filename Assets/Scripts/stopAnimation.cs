using UnityEngine;
using System.Collections;

public class stopAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		animation.Play();
	}
	
	// Update is called once per frame
	void Update () {
		foreach(AnimationState anim in animation)
		{
			Debug.Log(anim.name);
		}
	}
}
