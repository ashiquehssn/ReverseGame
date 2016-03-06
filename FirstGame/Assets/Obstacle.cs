using UnityEngine;
using System.Collections;

public class Obstacle : AGComponent {
	private float speed;
	private float initialDelay;
	private float delay;

	void Start()
	{
		speed = Random.Range (0.2f, 0.4f);
		initialDelay = Random.Range (0.0f , 0.05f);
		if (transform.position.x > 0)
			speed = -speed;
	}
	// Update is called once per frame
	void Update () {
		
		if (!GameManager.IsGameRunning)
			return;
		if (delay < initialDelay) {
			delay += Time.deltaTime;
			return;
		}
		if(speed > 0)
			transform.Translate (new Vector3(1, 0.25f, 0) * speed);
		else if(speed > 0)
			transform.Translate (new Vector3(1, -0.25f, 0) * speed);
		else
			transform.Translate (Vector3.right * speed);

	}

	void OnBecameInvisible()
	{
		Destroy (gameObject);
	}
}
