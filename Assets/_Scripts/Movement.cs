using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float rotationSpeed = 3f;
	public float moveSpeed = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.forward * moveSpeed * 0.3f);
		}
		if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.forward * moveSpeed * 0.3f);
		}
		if (Input.GetKey (KeyCode.UpArrow) && Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.forward * moveSpeed * -0.5f);
		}
	   if(Input.GetKey(KeyCode.UpArrow))
        {   //(0,0,1);
            transform.Translate(Vector3.forward * moveSpeed);
           
        }
        
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed);
        }
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.up * rotationSpeed);
        }
        
        if(Input.GetKey(KeyCode.RightArrow))
        {
			transform.Rotate(Vector3.up * rotationSpeed);
        }

		if(Input.GetKey(KeyCode.W))
		{   //(0,0,1);
			transform.Translate(Vector3.forward * moveSpeed);
		}
		
		if(Input.GetKey(KeyCode.S))
		{
			transform.Translate(-Vector3.forward * moveSpeed);
		}
		
		if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate(-Vector3.up * rotationSpeed);
		}
		
		if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate(Vector3.up * rotationSpeed);
		}
	}
}
