using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject fallingblockPrefab;
	Vector2 halfscreen;
	public Vector2 secondsbetweenspawnMinMax;
	float nextSpawnTime;

	public float spawnAngle;
	public Vector2 minmax;
	// Use this for initialization
	void Start () {
		halfscreen = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > nextSpawnTime)
		{
			float secondsbetweenspawn = Mathf.Lerp(secondsbetweenspawnMinMax.y, secondsbetweenspawnMinMax.x,Difficulty.GetDifficultyPercentage());
			nextSpawnTime = Time.time + secondsbetweenspawn;
			float spawnsize = Random.Range(minmax.x, minmax.y);
			float angle = Random.Range(spawnAngle, -spawnAngle);
			Vector2 spawnpos = new Vector2(Random.Range(-halfscreen.x, halfscreen.x), halfscreen.y + spawnsize/2);
			GameObject newBlock = (GameObject)Instantiate(fallingblockPrefab, spawnpos, Quaternion.Euler(Vector3.forward * angle));
			newBlock.transform.localScale = Vector2.one * spawnsize;
		}
		}
}
