using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour 
{
	public GameObject BallPrefab;

	int randomPosX;
	int randomPosY;

	void Start()
	{
		Spawn();
	}

	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Spawn();
		}
	}

	void CreateRandomPosition(int xMax, int yMax)
	{
		randomPosX = Random.Range(-8, 8);
		randomPosY = Random.Range(-4, 4);
	}

	void Spawn()
	{
		CreateRandomPosition(7, 4);

		Instantiate(BallPrefab, new Vector3(randomPosX, randomPosY, 0), Quaternion.identity);
	}
}