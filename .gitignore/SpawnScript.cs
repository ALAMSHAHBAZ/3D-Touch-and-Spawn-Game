using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

	public GameObject trash;
	 public  float timeDelay = 0.5f;
     private float timestamp;

	// Use this for initialization
	    void Start()
    {
        timestamp = Time.time + timeDelay;
    }

	
	// Update is called once per frame
	void Update () {

		if ((Input.touchCount > 0) && (Input.GetTouch (0).phase == TouchPhase.Began )&& (Time.time > timestamp)) {
			Touch touch = Input.GetTouch (0);
			Vector2 touchPos = Camera.main.ScreenToWorldPoint (touch.position);
            	//if (touch.phase == TouchPhase.Began)
				Instantiate (trash, touchPos, Quaternion.identity);
				timestamp = Time.time + timeDelay;          
			
		}
		
	}
}
