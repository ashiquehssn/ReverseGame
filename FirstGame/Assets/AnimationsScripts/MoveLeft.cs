using UnityEngine;
using System.Collections;

public class MoveLeft : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}

	int rand = -500;
	// Update is called once per frame
	void Update () {
	
			transform.Translate(-Vector3.right * speed);

			if(transform.position.x <= rand)
			{
				transform.position = new Vector3(600, transform.position.y, transform.position.z);
				rand = Random.Range(-300, -600);
			}

	}
}
