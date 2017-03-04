using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public GameObject Cube;
	public GameObject Sphere;
	public float distance;
	private int flag = 0;
	
/*	
	private void OnCollisionEnter(Collision collision)
	{
	
		if (collision.gameObject.tag == "ground")
		{
			//distance calulation
			float distance = Vector3.Distance(Cube.transform.position, Sphere.transform.position);
	
			guiText.text = distance.ToString();

		}
	}
*/

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//distance calulation
		if(Input.GetKey ("space")){
			flag = 1;
		}
		if(flag == 1){
			distance = Vector3.Distance(Cube.transform.position, Sphere.transform.position);

			guiText.text = distance.ToString() + "[m]";
		}

	}
}
