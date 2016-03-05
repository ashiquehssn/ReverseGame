using UnityEngine;
using System.Collections;

public abstract class PlayerController : AGComponent 
{
	 
	[SerializeField] private float minSpeed = 0.5f;
	[SerializeField] private float maxSpeed = 1.5f;
	[SerializeField] private float timeForMaxSpeed = 60f;  //time in second
	[SerializeField] private float brakeTime = 10;

	
	private float mSpeed = 0.5f;
	private float mBrakeFactor = 1;
	private float timeFactor;
	private float mSpeedIncreamentFactor = 0.2f;

	protected void Init()
	{
		timeFactor = 1 / timeForMaxSpeed;
	}
	
	protected void Move (bool inIsBraking) 
	{
		if (inIsBraking)
			mBrakeFactor = Mathf.MoveTowards (mBrakeFactor, 0, brakeTime * Time.deltaTime * 0.2f);
		else
		{
			SpeedAcceleration ();
			mBrakeFactor = 1;
		}
		print (mBrakeFactor);
		transform.Translate (Vector3.up * mSpeed * mBrakeFactor);
		print ("speed " + Vector3.up * mSpeed * mBrakeFactor );

	}

	private void SpeedAcceleration ()
	{
		mSpeedIncreamentFactor = Mathf.MoveTowards (mSpeedIncreamentFactor, 1, timeFactor * Time.deltaTime);
		mSpeed = Mathf.Lerp(minSpeed, maxSpeed, mSpeedIncreamentFactor);
		print ("mSpeed " + mSpeed);
	}


}
