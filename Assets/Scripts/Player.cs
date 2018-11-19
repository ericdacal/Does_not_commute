using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Transform myTransform;
	private float speed;
	private float xAxis,zAxis;
	
	// Use this for initialization
	void Start () 
	{
		speed = 2.0f;
		myTransform = GetComponent <Transform>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		xAxis = Input.GetAxis("Horizontal");
		zAxis = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(xAxis,0,zAxis);
		myTransform.Translate(movement*(this.speed)*Time.deltaTime);
		
	}
}
