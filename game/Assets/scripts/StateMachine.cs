using UnityEngine;
using System.Collections;

public class StateMachine : MonoBehaviour {

	private BattleStates curentState;

	public enum BattleStates
	{
		START,
		PLAYERCHOISE,
		ENEMYCHOISE,
		LOSE,
		WIN
	}


	// Use this for initialization
	void Start () {
		curentState = BattleStates.START;

	}
	
	// Update is called once per frame
	void Update () {
		switch (curentState) {
		
		case(BattleStates.START):
			break;
		case BattleStates.PLAYERCHOISE:
			break;
		case BattleStates.ENEMYCHOISE:
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
