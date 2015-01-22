using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	public int maxHealth = 10;
	public int curHealth = 10;
	
	public float healthBarLength;
	
	
	void Start () {
		healthBarLength = Screen.width / 2;
	}
	
	
	void Update () {
		AddjustCurrentHealth(0);
		
	}

	void OnCollisionEnter(Collision coll)
	{
				if (coll.gameObject.name == "Shell(Clone)") {
						curHealth--;
						if (curHealth <= 0) {
								Destroy (this.gameObject);
						}
			
				}
		}
	
	void OnGUI(){
		GUI.Box(new Rect(10, 10, healthBarLength, 20), curHealth + "/" + maxHealth);	
	}
	
	
	public void AddjustCurrentHealth(int adj) {
		curHealth += adj;	
		
		if(curHealth < 0)
			curHealth = 0;
		
		if(curHealth > maxHealth)
			curHealth = maxHealth;
		
		if(maxHealth < 1)
			maxHealth = 1;
		
		healthBarLength = (Screen.width / 2) * (curHealth / (float)maxHealth);
	}
}