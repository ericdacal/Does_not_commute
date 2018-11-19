using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_movement : MonoBehaviour {
	private Transform myTransform;
	private Transform playerPos;
	private Vector3 aPosition;
	
	// Use this for initialization
	void Start () 
	{
		myTransform = GetComponent <Transform>();
		playerPos = GameObject.Find("Cube").GetComponent<Transform>();
		aPosition = playerPos.position;
		myTransform.Translate(aPosition);
		myTransform.Translate(0f,5f,0f,Space.World);
	}
	
	// Update is called once per frame
	void Update () 
	{
		float diff = playerPos.position.x - aPosition.x;
		if(diff != 0) 
		{
			myTransform.Translate(-diff,0f,0f,Space.World);
		}
		//myTransform.Translate(new Vector3(playerPos.position.x, playerPos.position.y + 5, playerPos.position.z)); 
	}
}
