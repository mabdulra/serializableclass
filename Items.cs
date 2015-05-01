using UnityEngine;
using System.Collections;

/**
 *	This class only stores save/load item features
 *	Other aspects (including graphics, names) are not serialized
 *	This is done to reduce overall file size
 */
[System.Serializable]
public class Item
{
	//	Attributes of items
	public int id;
	public int count;

	//	By default, when you get a new item you get only one
	//	But it is possible to get more than 1 item at a time
	public Item(int id, int count = 1)
	{
		this.id = id;
		this.count = count;

		//	Currently this is blank, but it can expand in the future potentially
		switch(this.id)
		{
			case Constants.POTION:
				break;
			default:
				Debug.Log("UNSUPPORTED ID "+this.id+" PASSED TO Item CONSTRUCTOR");
				break;
		}
	}
}
