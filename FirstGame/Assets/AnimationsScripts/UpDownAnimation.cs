using UnityEngine;
using System.Collections;
using MyFramework;

public class UpDownAnimation : MonoBehaviour {

	public float diff;
//	public float time;
//	public float delay;

	public float speed;

	float startPos;
	// Use this for initialization
	void Start ()
	{
		startPos = transform.position.y;
//		Animations.Move(gameObject, new Vector3(transform.position.x, transform.position.y - diff, transform.position.z),
//		                new Vector3(transform.position.x, transform.position.y + diff, transform.position.z), time, delay, _EaseType.linear, -1, false, true);

	}

	bool isUp = true;
	bool isDown;
	// Update is called once per frame
	void Update () 
	{
		if(isUp)
		{
			transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, startPos + diff, transform.position.z), Time.deltaTime * speed);
			if(transform.position.y >= startPos + diff)
			{
				isUp = false;
				isDown = true;
			}
		}
		else if(isDown)
		{
			transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, startPos - diff, transform.position.z), Time.deltaTime * speed);
			if(transform.position.y <= startPos - diff)
			{
				isUp = true;
				isDown = false;
			}
		}
//		transform.Translate(-Vector3.right * 0.1f);
	}
	IEnumerator WaitAndDestroy()
	{
		yield return new WaitForSeconds(4);
		Destroy(gameObject);
	}
}
