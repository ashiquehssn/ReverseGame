using UnityEngine;
using System.Collections;

public class MouseHandler : MonoBehaviour {


	Ray ray;
	public RaycastHit2D hit;
	void Update()
	{
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		hit = Physics2D.Raycast (ray.origin, ray.direction);
		if(Input.GetMouseButtonDown(0))
		{
			GetMouseDown();
		}
		else if(Input.GetMouseButton(0))
		{
			GetMouse();
		}
		else if(Input.GetMouseButtonUp(0))
		{
			GetMouseUp();
		}
	}

	public virtual  void GetMouseDown()
	{
	}
	public virtual void GetMouse()
	{
	}
	public virtual void GetMouseUp()
	{
	}
}
