using UnityEngine;
using System.Collections;

public class gameover : MonoBehaviour {
	
	protected virtual void CheckTouch()
    {
        if ( Input.touchCount <= 0 )
        {
            return; 
        }
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Touch touch = Input.GetTouch(0);
		if (Input.GetButton("Jump")) {
		//if ( touch.phase == TouchPhase.Began ) {
        	Application.LoadLevel("Title");
		}
	
	}
}
