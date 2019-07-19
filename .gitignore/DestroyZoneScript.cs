using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZoneScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		//ScoreScript.scoreValue+=1;
		Destroy (col.gameObject);

	}
}
