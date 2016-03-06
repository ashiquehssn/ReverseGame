using UnityEngine;
using System.Collections;
using MyFramework;

public class RotateLeaf : MonoBehaviour {

	public float _angle;
//	public float _endAngle;
	public float _time;
	public float _waitTime;

	// Use this for initialization
	void Start () {
		Animations.Rotate(gameObject, new Vector3(transform.rotation.x, transform.rotation.y, _angle),
		                  new Vector3(transform.rotation.x, transform.rotation.y, -_angle), _time, _waitTime, _EaseType.linear, -1, false, true);
	}

	public IEnumerator StartAnimation(float delay)
	{
		yield return new WaitForSeconds(delay);

	}
	
	// Update is called once per frame
	void Update () {

	}
}
