using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour {

	public Vector2 speedMinMax;
	float speed = 7;
	// Use this for initialization
	// Update is called once per frame
	float visibleThreshold;
	void Start()
	{
		speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y,Difficulty.GetDifficultyPercentage());
		visibleThreshold = -Camera.main.orthographicSize - transform.localScale.y;
	}
	void Update () {
		transform.Translate(Vector2.down * speed * Time.deltaTime);

		if(transform.position.y < visibleThreshold)
		{
			Destroy(gameObject);
		}
	}
}
