using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

//	Inherits MonoBehaviour and allows all public attributes to be
//	accessible in the Unity editor! Very useful for development
public class GameController : MonoBehaviour
{
	//	All UI elements are here, critical save data is serializable exclusively within Game
	public Game game = null;

	//	Save the game
	void Save()
	{
		SaveLoad.Save(game);
	}

	//	Load the game
	void Load()
	{
		game = SaveLoad.Load();
	}

	// If there is no save file, make one and save it, otherwise load a file
	void Start()
	{
		Load();
		if( game == null )
		{
			game = new Game();
			Save();
		}
	}
}
