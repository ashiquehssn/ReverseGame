using UnityEngine;
using System.Collections;
using MyFramework;

public class MoveLeftRight : MonoBehaviour {

	public float _EndPos;
	public float _time;
	public float _delay;
	// Use this for initialization
	void Start () 
	{
		Animations.Move(gameObject, transform.position, new Vector3(_EndPos, transform.position.y, transform.position.z), _time, _delay);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
