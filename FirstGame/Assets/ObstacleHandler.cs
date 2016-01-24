using UnityEngine;
using System.Collections.Generic;

public class ObstacleHandler : MonoBehaviour {

	[SerializeField] Camera playerCamera;
	[SerializeField] GameObject obstaclePrefab;
	[SerializeField] float[] points;

	// Use this for initialization
	void Start () 
	{
		//for (int i =0; i< count; i++)
		//	obstacles [i] = Instantiate (obstaclePrefab) as GameObject;
		InvokeRepeating ("GenerateObstacle", 5, 2);
	}

	void GenerateObstacle()
	{
		if (!GameManager.IsGameRunning)
			return;
		GameObject temp = Instantiate (obstaclePrefab) as GameObject;
		Vector3 tPosition = playerCamera.ViewportToWorldPoint(new Vector3(Random.Range(0,2) , points[Random.Range(0,2)] , 0));
		if(tPosition.x > 0)
			tPosition.x += 2;
		else
			tPosition.x -= 2;
		tPosition.z = 0;
		temp.transform.position = tPosition;
	}
}
