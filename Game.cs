using UnityEngine;
using System.Collections;

[System.Serializable]
public class Game
{
	public static Game			current;
	public PlayerCharacter[]	players;
	public ItemInventory[]		items;

	public Game(int time)
	{
		players = new PlayerCharacter[4];
		items	= new ItemInventory[128];
	}
}
