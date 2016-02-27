using UnityEngine;
using System.Collections;

public class SwitchCameraBack : MonoBehaviour 
{
	void OnMouseDown()
	{
		transform.localScale *= 1.1F;
	}

	void OnMouseUp()
	{
		Application.LoadLevel (0);
	}
}
