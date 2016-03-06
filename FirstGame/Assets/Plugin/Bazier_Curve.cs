using UnityEngine;
using System.Collections;

public class Bazier_Curve : MonoBehaviour
{
	float _time;
	int _index;
	int _curveNo;
	Vector2 _pos;
	Vector2[] _bazierPos;
	public float _speedAfterCollision;
	// Use this for initialization
	void Start ()
	{
	  //_speedAfterCollision=300;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void WavePoint(Vector2[] p_bazierPos,int p_curveNo)
	{
		_time=0;
		_index=0;
		_curveNo=p_curveNo;
		_pos=new Vector2(0,0);
		_bazierPos=new Vector2[p_bazierPos.Length];
		for(int i=0;i<4;i++)
		{
			_bazierPos[i]=p_bazierPos[i];
		}	
	}
	
	public int getCurveNo()
	{
		return _curveNo;
	}	
	
	public Vector2 getEndPosition()
	{
		return _bazierPos[3];
	}
	
	public Vector2 getSegmentPoint()
	{
		if(_index++<_speedAfterCollision)
    	{
        	float x= Mathf.Pow(1 - _time, 3) * 0 + 3.0f * Mathf.Pow(1 - _time, 2) * _time * (_bazierPos[1].x-_bazierPos[0].x) + 3.0f * (1 - _time) * _time * _time * (_bazierPos[2].x-_bazierPos[0].x) + _time * _time * _time * (_bazierPos[3].x-_bazierPos[0].x);
       		float y= Mathf.Pow(1 - _time, 3) * 0 + 3.0f * Mathf.Pow(1 - _time, 2) * _time * (_bazierPos[1].y-_bazierPos[0].y) + 3.0f * (1 - _time) * _time * _time * (_bazierPos[2].y-_bazierPos[0].y) + _time * _time * _time * (_bazierPos[3].y-_bazierPos[0].y);
        	_pos=new Vector2(x+_bazierPos[0].x,y+_bazierPos[0].y);
        	_time += 1.0f /(_speedAfterCollision);
    	}
    	else
    	{
        	_pos=_bazierPos[3];//end point
    	}
    	return _pos;
	}
	
	public void setReversePosition()
	{
		//swap start and end point
    	Vector2 temp;
    	temp=_bazierPos[3];
    	_bazierPos[3]=_bazierPos[0];
   		_bazierPos[0]=temp;
    
		//swap control point
    	temp=_bazierPos[2];
    	_bazierPos[2]=_bazierPos[1];
    	_bazierPos[1]=temp;
    	_time=0;
    	_index=0;
	}

	public Vector2 getStartPosition()
	{
    	return _bazierPos[0]; //start point
	}

	public void setContinuesPosition()
	{
    	_time=0;
    	_index=0;
	}
}
