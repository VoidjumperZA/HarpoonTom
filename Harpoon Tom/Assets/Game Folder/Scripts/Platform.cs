using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour 
{	
	[SerializeField] private int platformWidth;
	[SerializeField] private int platformHeight;
	private GameObject[][] platformGrid;
	// Use this for initialization
	void Start () 
	{
		platformGrid = new GameObject[platformWidth][platformHeight]; 
		for (int i = 0; i < platformWidth; i++) 
		{
			platformGrid[i] = Instantiate(Resources.Load("Resources/Prefabs/PlatformSegement"));
			for (int j = 1; j < platformHeight; j++) 
			{
				platformGrid[j] = Instantiate(Resources.Load("Resources/Prefabs/PlatformSegement"));
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{		
	}
}
