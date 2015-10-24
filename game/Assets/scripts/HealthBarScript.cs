using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {

	public Scrollbar Healthbar;
	public Scrollbar EnemyHealthbar;
	public float EnemyHealth = 100;
	public float Health = 100;

	public void Damage( float value)
	{
		Health -= value;
		Healthbar.size = Health / 100f;
		if (Health<1)
			Application.LoadLevel("MainMenu")	;	
	}


	public void Heal( float value)
	{

		if ((Health < 100f)&&(Health > 1))
		Health += value;
		Healthbar.size = Health / 100f;



	}



	public void EnemyDamage( float value)
	{
		EnemyHealth -= value;
		EnemyHealthbar.size = EnemyHealth / 100f;
		if (EnemyHealth<1)
			Application.LoadLevel("Adventure_level_2")	;	
	}



	public void EnemyHeal( float value)
	{
			if ((EnemyHealth < 100f)&&(EnemyHealth > 1))
				EnemyHealth += value;
		EnemyHealthbar.size = EnemyHealth / 100f;


	}





	/*public Transform mytransformOBJ;

	void Update()
	{
		transform.LookAt (mytransformOBJ);



	}*/

}
