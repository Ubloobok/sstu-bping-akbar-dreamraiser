using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StateMachine : MonoBehaviour {

	private BattleStates curentState;

	public Scrollbar Healthbar;
	public Scrollbar EnemyHealthbar;
	public float EnemyHealth = 100;
	public float Health = 100;

	public enum BattleStates
	{
		START,
		PLAYERCHOISE,
		COMPCHOISE,
		LOSE,
		WIN
	}






	int RandChoise  = Random.Range(0,1); /* ВЫБОР КТО БУДЕТ ПЕРВЫЙ ХОДИТЬ 0 - ИГРОК*/

	public void Damage( float value)//////// СКРИПТ УРОНА 
	{
		Health -= value;
		Healthbar.size = Health / 100f;
			if (Health<1)
				Application.LoadLevel("MainMenu")	;	
	}

	public void Heal( float value)///////// Скрипт ЛЕЧЕНИЯ
	{
		
		if ((Health < 100f)&&(Health > 1))
			Health += value;
			Healthbar.size = Health / 100f;
	}



	void StatePlayerChoise()
	{
		if (GameObject.Find("Canvas/HeroDamage"). {
			Damage (10);
		} else
			if (gameObject.name == "HeroHeal") 
		{
			Heal(10);
		}

	}


	// Use this for initialization
	void Start () {
		curentState = BattleStates.PLAYERCHOISE;

	//	if (RandChoise == 0)
			//PlayerChoide()

	//	if (RandChoise == 1)
				// EnemyChoise
			;
	}
	
	// Update is called once per frame
	void Update () {
		switch (curentState) {
		
		case(BattleStates.START):
			break;
		case BattleStates.PLAYERCHOISE:
			StatePlayerChoise();
			break;
		case BattleStates.COMPCHOISE:
			break;
		case BattleStates.LOSE:
			break;
		case BattleStates.WIN:
			break;

		}
	
	}

	void Fight()
	{
		
		
		
		
	}





}
