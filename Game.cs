using UnityEngine;
using System.Collections;

[System.Serializable]
public class Game
{
	public static Game			current;
	public PlayerCharacter[]	players;
	public Item[]				inventory;

	public Game()
	{
		//	Allocate arrays with maximum values set
		players 	= new PlayerCharacter[4];
		inventory	= new Item[128];

		//	Instantiate players
		players[0] = new PlayerCharacter(Constants.WARRIOR);
		players[1] = new PlayerCharacter(Constants.MAGELING);
		players[2] = new PlayerCharacter(Constants.DARKMAGE);
		players[3] = new PlayerCharacter(Constants.HEALER);

		//	Start game with one POTION in inventory
		inventory[0] = new Item(Constants.POTION);
	}
}
