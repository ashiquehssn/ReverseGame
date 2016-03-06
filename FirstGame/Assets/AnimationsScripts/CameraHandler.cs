using UnityEngine;
using System.Collections;
using MyFramework;

public class CameraHandler : MonoBehaviour {

	public Transform _frontWater;
	public Transform _backWater;
	public GameObject _topLeaf;
	public Transform _Crocodile;
	public float _xCamStartPos;
	public float _xCamEndPos;
	public float _time;
	// Use this for initialization
	void Start ()
	{
//		Animations.Move(gameObject, new Vector3(transform.position.x, transform.position.y, transform.position.z),
//		                new Vector3(_xCamEndPos, transform.position.y, transform.position.z), _time, 0f);
//		Animations.Move(gameObject, new Vector3(_xCamEndPos, transform.position.y, transform.position.z),
//		                new Vector3(_xCamStartPos, transform.position.y, transform.position.z), _time, _time);
//		Vector3 pos = _topLeaf.transform.position;
//		Animations.Move(_topLeaf, new Vector3(pos.x, pos.y - 0.1f, pos.z), new Vector3(pos.x, pos.y + 0.1f, pos.z), 2f, 0, _EaseType.linear, -1, false, true);

//		Animations.Move(_frontWater.gameObject, new Vector3(_frontWater.position.x, _frontWater.position.y - 0.05f, _frontWater.position.z),
//		                new Vector3(_frontWater.position.x, _frontWater.position.y + 0.05f, _frontWater.position.z), 1f, 0, _EaseType.linear, -1, false, true);
//		Animations.Move(_backWater.gameObject, new Vector3(_backWater.position.x, _backWater.position.y - 0.05f, _backWater.position.z),
//		                new Vector3(_backWater.position.x, _backWater.position.y + 0.05f, _backWater.position.z), 1.5f, 0, _EaseType.linear, -1, false, true);
//
//		Animations.Move(_Crocodile.gameObject, new Vector3(_Crocodile.position.x, _Crocodile.position.y - 0.05f, _Crocodile.position.z),
//		                new Vector3(_Crocodile.position.x, _Crocodile.position.y + 0.05f, _Crocodile.position.z), 1.5f, 0, _EaseType.linear, -1, false, true);
	}

	public void MoveCamera()
	{
		Animations.Move(gameObject, transform.position, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), 2f, 0, _EaseType.linear, 0, false, false, fun=>CallBack());
	}

	void CallBack()
	{
		Animations.Move(gameObject, transform.position, new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z), 1f, 0);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
