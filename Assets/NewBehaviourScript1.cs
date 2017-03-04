using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {
	
	public bool jump = false;
	public float force = 15.0f;
	
	private void FixedUpdate(){
		if(!jump && Input.GetMouseButtonDown(0)){
			jump = true;
			rigidbody.AddForce(transform.up * force,ForceMode.Impulse);
		}
	}
	
	private void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "jump"){
			jump = false;
		}
	}

}
