using UnityEngine;
using System.Collections;

public class Path : AGComponent {

	[SerializeField] private Transform topNeighbour;
	private bool mChangePathPart = false;

	void Start()
	{
		mChangePathPart = true;
	}

	void OnBecameInvisible()
	{
		if (!mChangePathPart)
			return;
		transform.position = Vector3.up * (topNeighbour.position.y + 10);
	}
}
