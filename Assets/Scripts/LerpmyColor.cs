using UnityEngine;
using System.Collections;

public class LerpmyColor : MonoBehaviour {

	public Material startMaterial;
	public Material endMaterial;
	private float t = 0;
	public float duration = 3;
	// Use this for initialization
	private bool doTheLearp = false;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (doTheLearp)
		{
			renderer.material.color = Color.Lerp(startMaterial.color, endMaterial.color, t);
			if (t < 1)
			{
				t += Time.deltaTime/duration;
			}
		}

	}
}
