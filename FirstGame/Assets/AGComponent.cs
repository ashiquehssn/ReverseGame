using UnityEngine;

public class AGComponent : MonoBehaviour
{
	Transform mTransform;
	GameObject mGameObject;
	Canvas mCanvas;

	new public Transform transform 
	{
		get 
		{
			if(mTransform == null)
				mTransform = GetComponent<Transform>();
			return mTransform;
		}
	}

	new public GameObject gameObject {
		get 
		{
			if(mGameObject == null)
				mGameObject = GetComponent<GameObject>();
			return mGameObject;
		}
	}

	 public Canvas canvas {
		get 
		{
			if(mCanvas == null)
				mCanvas = GetComponent<Canvas>();
			return mCanvas;
		}
	}
}
