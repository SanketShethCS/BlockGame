using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Difficulty{

	static float secondstomax = 60;

	public static float GetDifficultyPercentage()
	{
		
		return Mathf.Clamp01(Time.timeSinceLevelLoad / secondstomax);
	}
}
