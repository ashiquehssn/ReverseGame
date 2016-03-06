using UnityEngine;
using System.Collections;

public class BazierCurve : MonoBehaviour {

	public Vector2[] _controlPoints;
	float BezierTime;
	float CurveX;
	float CurveY;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		BezierTime = BezierTime + Time.deltaTime;
		
		if (BezierTime >= 1)
		{
			BezierTime = 0;
		}
		
		CurveX = (((1-BezierTime)*(1-BezierTime)) * _controlPoints[0].x) + (2 * BezierTime * (1 - BezierTime) * _controlPoints[1].x) + ((BezierTime * BezierTime) * _controlPoints[2].x);
		CurveY = (((1-BezierTime)*(1-BezierTime)) * _controlPoints[0].y) + (2 * BezierTime * (1 - BezierTime) * _controlPoints[1].y) + ((BezierTime * BezierTime) * _controlPoints[2].y);
		transform.position = new Vector3(CurveX, CurveY, 0);
	}
}
