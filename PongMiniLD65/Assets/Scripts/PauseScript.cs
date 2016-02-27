using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour 
{
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			if (Time.timeScale == 1)//means if not pause
				Time.timeScale = 0;//then pause the game
			else
				Time.timeScale = 1;//else resume the game
		}
	}
}
