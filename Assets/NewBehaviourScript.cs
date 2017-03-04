using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public GameObject syujinkou;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3(
			syujinkou.transform.position.x,
			syujinkou.transform.position.y ,
			syujinkou.transform.position.z 
			);
		transform.LookAt(syujinkou.transform);
	
	}
}
