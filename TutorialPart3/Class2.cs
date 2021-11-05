using System;

public class Class1
{	
	public string FirstName { get; set; }
	public string LastName { get; set; }

	public string GetFullName() 
	{
		return FirstName + " " + LastName;
	}
	
}
