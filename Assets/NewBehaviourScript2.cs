using UnityEngine;
using System.Collections;

public class NewBehaviourScript2 : MonoBehaviour {
	private int flag = 0;
	private int flag_text = 0;
	GUIStyle labelStyle;
	    
	protected virtual void CheckTouch()
    {
        if ( Input.touchCount <= 0 )
        {
            return; 
        }  
	}
	
	private void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "jumpJudge1"){
			
			if(flag == 0){
				if(Input.GetKey ("space")){
					rigidbody.velocity = (Vector3.up + Vector3.forward) * 50;
					flag = 1;
				}
			}
		}
		if (other.gameObject.tag == "jumpJudge2"){
			if(flag == 0){
				if(Input.GetKey ("space")){
					rigidbody.velocity = (Vector3.up + Vector3.forward) * 20;
					flag = 1;
				}
			}
		}
		if (other.gameObject.tag == "jumpJudge3"){
			if(flag == 0){
				if(Input.GetKey ("space")){
					rigidbody.velocity = (Vector3.up + Vector3.forward) * 15;
					flag = 1;
				}
			}
		}
	}
	
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "ground")
		{	 
			rigidbody.velocity = Vector3.zero;
    		rigidbody.angularVelocity = Vector3.zero;
			flag_text = 1;
		}
	}
	

	// Use this for initialization
	void Start () {
		labelStyle = new GUIStyle();
		labelStyle.fontSize = 30;
	}
	
	void OnGUI(){
		if(flag_text == 1){
			Rect rect = new Rect(100,100,400,300);
    		GUI.Label(rect, "Retry to Touch Space", labelStyle);
			if(Input.GetKey ("space")){
				Application.LoadLevel("game");
			}
		}
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
