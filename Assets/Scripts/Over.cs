using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Over : MonoBehaviour
{
	public GameObject gameoverScreen;
	// Use this for initialization
	public Text secondsSurvived;
	bool go;

	// Update is called once per frame
	void Update()
	{
		if (go)
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				SceneManager.LoadScene(0);
			}
		}
	}

	public void OnOver()
	{
		gameoverScreen.SetActive(true);
		secondsSurvived.text = Time.timeSinceLevelLoad.ToString();
		go = true;
	}
}
