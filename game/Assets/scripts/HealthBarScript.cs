using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {

	public Scrollbar Healthbar;
	public Scrollbar EnemyHealthbar;
	public float EnemyHealth = 100f;
	public float Health = 100;

	public void Damage( float value)
	{
		Health -= value;
		Healthbar.size = Health / 100f;
		if (Health<1)
			Application.LoadLevel("MainMenu")	;	
	}

	public void EnemyDamage( float value)
	{
		EnemyHealth -= value;
		EnemyHealthbar.size = EnemyHealth / 100f;
		if (EnemyHealth<1)
			Application.LoadLevel("Adventure_level_2")	;	
	}





	/*public Transform mytransformOBJ;

	void Update()
	{
		transform.LookAt (mytransformOBJ);



	}*/

}
