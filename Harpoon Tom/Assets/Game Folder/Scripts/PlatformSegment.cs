using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSegment : MonoBehaviour 
{	
	[Range(0, 100)] private int health;
	private bool reinforced;
	// Use this for initialization
	void Start () 
	{		
		health = 100;
		reinforced = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	/// <summary>
	/// Flat out replaces existing health value
	/// </summary>
	/// <param name="pNewHealth">P new health.</param>
	public void SetHealth(int pNewHealth)
	{
		
	}

	/// <summary>
	/// Increments the health by given value.
	/// </summary>
	/// <param name="pDeltaHealth">P delta health.</param>
	public void IncrementHealth(int pDeltaHealth)
	{
		
	}

	/// <summary>
	/// Gets the health.
	/// </summary>
	/// <returns>The health.</returns>
	public int GetHealth()
	{
		return health;
	}

	/// <summary>
	/// Re- or Uninforces the segment.
	/// </summary>
	/// <param name="pState">If set to <c>true</c> p state.</param>
	public void ReinforceSegment(bool pState)
	{
		reinforced = pState;
	}

	/// <summary>
	/// Determines whether this instance is reinforced.
	/// </summary>
	/// <returns><c>true</c> if this instance is reinforced; otherwise, <c>false</c>.</returns>
	public bool IsReinforced()
	{
		return reinforced;
	}
}
