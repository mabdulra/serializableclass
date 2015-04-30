using UnityEngine;
using System.Collections;

[System.Serializable]
public class Game
{
	public static Game			current;
	public PlayerCharacter[]	players;
	public Item[]				inventory;

	public Game(int time)
	{
		//	Allocate arrays with maximum values set
		players 	= new PlayerCharacter[4];
		iventory	= new Item[128];

		//	Instantiate players
		players[0] = new PlayerCharacter(C.WARRIOR);
		players[1] = new PlayerCharacter(C.MAGELING);
		players[2] = new PlayerCharacter(C.DARKMAGE);
		players[3] = new PlayerCharacter(C.HEALER);

		//	Start game with one POTION in inventory
		items[0] = new Item(C.POTION);
	}
}
