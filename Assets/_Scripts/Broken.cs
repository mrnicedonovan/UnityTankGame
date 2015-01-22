using UnityEngine;
using System.Collections;

public class Broken : MonoBehaviour {

	public int lives = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision coll)
	{
		print("test123" + coll.gameObject.name);
		if (coll.gameObject.name == "Shell(Clone)")
		{
			lives--;
			if(lives <= 0)
			{
				Destroy(this.gameObject);
			}
		
		}
	}
}
