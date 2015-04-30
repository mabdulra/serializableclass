using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

/**
 *	This class interfaces with Game objects
 *	Using BinaryFromatter, it writes/reads to/from files
 */
public static class SaveLoad
{
	private const string SAVEPATH = "/savedGame.bin";

	public static void Save(Game savedGame)
	{
		Debug.Log("START OF SAVE GAME PROCESS");

		BinaryFormatter bf	= new BinaryFormatter();
		FileStream file		= File.Create(Application.persistentDataPath+SAVEPATH);
		bf.Serialize(file, savedGame);
		file.Close();

		Debug.Log("END OF SAVE GAME PROCESS");
	}

	public static Game Load()
	{
		Debug.Log("START OF LOAD GAME PROCESS");
		Debug.Log(Application.persistentDataPath + SAVEPATH);

		if( File.Exists(Application.persistentDataPath+SAVEPATH) )
		{
			BinaryFormatter bf	= new BinaryFormatter();
			FileStream file		= File.Open(Application.persistentDataPath+SAVEPATH, FileMode.Open);
			Game savedGame		= (Game)bf.Deserialize(file);
			file.Close();
			Debug.Log("END OF LOAD GAME PROCESS");
			return savedGame;
		}

		Debug.Log("END OF LOAD GAME PROCESS (NO SAVE GAME FOUND)");
		return null;
	}
}
