using UnityEngine;
using System.Collections;

public class Push : MonoBehaviour {

	public float pushPower = 2.0F;
	public 		GameObject pickedUpObject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if(Input.GetKey("e")){
			if(Physics.Raycast(transform.position,transform.forward,out hit,100)){//the order of the parameters might be wrong.
				if(hit.collider.gameObject.tag=="DynamicObject"){ //i used a tag to see whether the object cn be picked up, you can use another method that may suit you better
					pickedUpObject=hit.collider.gameObject; //we use this to determine whether an object is picked up by the player. If it's not null, then the player is doing so.
					hit.collider.gameObject.transform.parent=transform; //attach the object to the camera so it moves along with it.
					hit.collider.gameObject.transform.position=transform.position-transform.forward; //might need changing as it's untested.
				}
			}
		}
		else if(pickedUpObject!=null){ //if player is not holding E but was picking up an object last frame
			pickedUpObject.transform.parent=null; //drop the object
			pickedUpObject=null;  //and nullify the object pointer
		}
	}


	void OnControllerColliderHit(ControllerColliderHit hit) {
		Rigidbody body = hit.collider.attachedRigidbody;
		if (body == null || body.isKinematic)
			return;
		
		if (hit.moveDirection.y < -0.3F)
			return;
		
		Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
		body.velocity = pushDir * pushPower;
	}
}
