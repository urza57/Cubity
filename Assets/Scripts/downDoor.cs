using UnityEngine;
using System.Collections;

public class downDoor : MonoBehaviour {

	public GameObject interrupteur1;
	public GameObject interrupteur2;
	public GameObject interrupteur3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if((interrupteur1.renderer.material.color == Color.green )
		   && (interrupteur2.renderer.material.color == Color.green)
		   && (interrupteur3.renderer.material.color == Color.green)) {
			if(gameObject.transform.position.y >= -10.0f){
				transform.Translate(new Vector3 (0, -1, 0) * Time.deltaTime);
			}
		}		
	}
}
