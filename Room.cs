using System;

public class Room
{
	public string name, description;
	public Room(string nameIn, string descriptionIn)
	{
		name = nameIn;
		description = descriptionIn;
	}

	public override string ToString()
	{
		return name + "\n\n" + description + "\n";
	}
}
