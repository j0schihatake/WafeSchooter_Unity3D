using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI : MonoBehaviour {
	
	public Text scoreTxt;		//The Text component depicting the current score
	public Text ammoTxt;		//The Text component depicting the player's current ammo
	public Text moneyTxt;		//The Text component depicting the player's current money
	public Text waveTxt;		//The Text component depicting the current wave
	public Text waveTimeTxt;	//The Text component depicting the time left in the wave
	
	public Slider healthBar;	//The Slider which shows the players health 
	public Text hpTxt;			//The Text component depicting the players current and maximum health
	
	void Update ()
	{
		scoreTxt.text = "Score: " + Game.score;
		ammoTxt.text = "Ammo: " + Player.ammo;
		moneyTxt.text = "Money: $" + Player.money;
		waveTxt.text = "Wave: " + Game.curWave;
		waveTimeTxt.text = "Time Left: " + Game.curWaveTime;
		
		healthBar.value = Player.curHp;
		healthBar.maxValue = Player.maxHp;
		hpTxt.text = Player.curHp + "/" + Player.maxHp;
	}
}
