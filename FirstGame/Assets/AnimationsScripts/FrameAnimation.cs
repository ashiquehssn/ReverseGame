using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class FrameAnimation : MonoBehaviour {

	public Sprite[] _AnimationFrames;
	public float delay;
	public float frameDelay;

	int count;
	public bool _IsStartAnim = false;
	public bool _IsRandomAnimDelay;
	public bool _IsOnceAnim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(_IsStartAnim)
		{
			delay += Time.deltaTime;

			if(delay >= frameDelay && count < _AnimationFrames.Length)
			{

				GetComponent<Image>().sprite = _AnimationFrames[count++];

				if(count.Equals(_AnimationFrames.Length))
				{
					if(_IsOnceAnim)
					{
						_IsStartAnim = false;
					}
					else
					count = 0;
					if(_IsRandomAnimDelay)
					{
						_IsStartAnim = false;
						StartCoroutine(WaitAndDo(Random.Range(3, 5)));
					}
				}

				delay = 0;
			}
		}
	}

	IEnumerator WaitAndDo(float delay)
	{
		yield return new WaitForSeconds(delay);
			_IsStartAnim = true;
	}
	public IEnumerator WaitAndStopAnimation(float delay)
	{
		yield return new WaitForSeconds(delay);
		_IsStartAnim = false;
	}
	public IEnumerator WaitAndSetImage(int index, float delay)
	{
		yield return new WaitForSeconds(delay);
		GetComponent<SpriteRenderer>().sprite = _AnimationFrames[index];
	}
}
