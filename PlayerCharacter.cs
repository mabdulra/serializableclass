using UnityEngine;
using System.Collections;

[System.Serializable]
public class PlayerCharacter
{
	public string name;
	public int experience;
	public int level;
	public int nextLevel;

	public PlayerCharacter()
	{
		experience = 0;
		level = 1;
		nextLevel = 60;
	}

	public void GainLevel()
	{
		if( experience >= nextLevel )
		{
			experience -= nextLevel;
			nextLevel *= 2;
			level += 1;
		}
	}
}
