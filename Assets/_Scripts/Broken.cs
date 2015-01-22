using UnityEngine;
using System.Collections;

public class Broken : MonoBehaviour {

	public AudioClip boom;
	public int lives = 20;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {}

	void OnCollisionEnter(Collision coll)
	{
		if (coll.gameObject.name == "Shell(Clone)")
		{
			lives--;
			if(lives <= 0)
			{
				Destroy(this.gameObject);
				audio.PlayOneShot(boom);
			}
		
		}
	}
}
