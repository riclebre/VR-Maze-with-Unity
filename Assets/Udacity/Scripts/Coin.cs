using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	//Create a reference to the CoinPoofPrefab
	public GameObject Poof;
 
	public void OnCoinClicked() {
		// Instantiate the CoinPoof Prefab where this coin is located
		Object.Instantiate(Poof, transform.position, Quaternion.Euler(-90, 0, 0));
		/* To make sure the poof animates vertically I used "transform.position, Quaternion.Euler"
		 more info about it on https://docs.unity3d.com/ScriptReference/Quaternion.Euler.html */

		// Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
		// make sure to use gameObject <p> and not GameObject <c>
	}

}