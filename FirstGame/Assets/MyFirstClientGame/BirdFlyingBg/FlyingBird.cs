using UnityEngine;
using System.Collections;

public class FlyingBird : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.right * 5.01f);

		if(transform.position.x >= 1600)
		{
			transform.position = new Vector3(Random.Range(-600, -250), transform.position.y, transform.position.z);
		}
	}
}
