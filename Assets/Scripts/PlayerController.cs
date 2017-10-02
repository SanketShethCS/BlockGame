using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 7;
	public float screenHalf;

	
	// Use this for initialization
	void Start () {
		float playerhalf = transform.localScale.x / 2f;
		screenHalf = Camera.main.aspect * Camera.main.orthographicSize + playerhalf;
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxisRaw("Horizontal");
		float velocity = inputX * speed;
		transform.Translate(Vector2.right * velocity * Time.deltaTime);
		
		if(transform.position.x <  -screenHalf)
		{
			transform.position = new Vector2(screenHalf, transform.position.y);
		}
		if (transform.position.x > screenHalf)
		{
			transform.position = new Vector2(-screenHalf, transform.position.y);
		}
	}
	void OnTriggerEnter2D(Collider2D triggerCollider)
	{
		if (triggerCollider.tag == "Falling Block")
		{
			//Over Last = GetComponent<Over>();
			//Last.OnOver();
			FindObjectOfType<Over>().OnOver();
			Destroy(this.gameObject);
		}
	}
}
