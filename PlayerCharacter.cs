using UnityEngine;
using System.Collections;

[System.Serializable]
public class PlayerCharacter
{
	//	Player character constants
	public static int WARRIOR	= 1;
	public static int MAGELINE	= 2;
	public static int DARKMAGE	= 3;
	public static int HEALER	= 4;

	//	Attributes of player characters
	public int id;
	public int hp;
	public int atk;
	public int def;
	public int spd;
	public int mAtk;
	public int mDef;
	public int costume;

	public PlayerCharacter(id)
	{
		this.id = id;
		int[] stats;

		//	Set initial stats specifically for each character
		switch(this.id)
		{
			case WARRIOR:
				stats = new int[]{50,30,30,30,0,15};
				break;
			case MAGELING:
				stats = new int[]{30,10,10,10,5,10};
				break;
			case DARKMAGE:
				stats = new int[]{30,20,10,20,10,10};
				break;
			case HEALER:
				stats = new int[]{70,50,20,25,5,10};
				break;
			default:
				Debug.Log("UNSUPPORTED ID"+this.id+"PASSED TO PlayerCharacter CONSTRUCTOR");
				stats = new int[]{0,0,0,0,0,0};
				break;
		}

		//	Push stats from array to attributes
		this.hp		= stats[0];
		this.atk	= stats[1];
		this.def	= stats[2];
		this.spd	= stats[3];
		this.mAtk	= stats[4];
		this.mDef	= stats[5];

		//	Until costumes are implemented fully, set them to default 0
		this.costume = 0;
	}
}
