using UnityEngine;
using System.Collections;

/**
 *	This class only stores save/load player features
 *	Other aspects (including graphics, names) are not serialized
 *	This is done to reduce overall file size
 */
[System.Serializable]
public class PlayerCharacter
{
	//	Attributes of player characters
	public int id;
	public int hp;
	public int atk;
	public int def;
	public int spd;
	public int mAtk;
	public int mDef;
	public int costume;

	public PlayerCharacter(int id)
	{
		int[] stats;
		this.id = id;

		//	Set initial stats specifically for each character
		switch(this.id)
		{
			case C.WARRIOR:
				stats = new int[]{50,30,30,30,0,15};
				break;
			case C.MAGELING:
				stats = new int[]{30,10,10,10,5,10};
				break;
			case C.DARKMAGE:
				stats = new int[]{30,20,10,20,10,10};
				break;
			case C.HEALER:
				stats = new int[]{70,50,20,25,5,10};
				break;
			default:
				Debug.Log("UNSUPPORTED ID "+this.id+" PASSED TO PlayerCharacter CONSTRUCTOR");
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

		//	All characters start in default styled costume
		this.costume = C.COSTUME_DEFAULT;
	}
}
