using UnityEngine;
using System.Collections;

public abstract class PlayerController : AGComponent 
{
	 
	[SerializeField] private float minSpeed = 0.5f;
	[SerializeField] private float maxSpeed = 1.5f;
	[SerializeField] private float timeForMaxSpeed = 60f;  //time in second
	[SerializeField] private float brakeTime = 10;
	[SerializeField] private GameObject tyreSkidMark;

	
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

		if (mBrakeFactor < 0.7 && !tyreSkidMark.activeSelf) 
		{
			tyreSkidMark.transform.position = new Vector3(0f,transform.position.y - 1.5f, 0f);
			tyreSkidMark.SetActive (true);
		}

		if(tyreSkidMark.transform.position.y + 3 < transform.position.y && tyreSkidMark.activeSelf)
			tyreSkidMark.SetActive (false);
		//print ("Factor " +mBrakeFactor);
		transform.Translate (Vector3.up * mSpeed * mBrakeFactor);
		//print ("speed " + Vector3.up * mSpeed * mBrakeFactor );

	}

	private void SpeedAcceleration ()
	{
		mSpeedIncreamentFactor = Mathf.MoveTowards (mSpeedIncreamentFactor, 1, timeFactor * Time.deltaTime);
		mSpeed = Mathf.Lerp(minSpeed, maxSpeed, mSpeedIncreamentFactor);
		//print ("mSpeed " + mSpeed);
	}

	public float GetBrakeFactore()
	{
		return mBrakeFactor;
	}


}
