using System;

namespace DesignPatternPractice
{
	public class ArcherCreator: Creator
	{
		public ArcherCreator ()
		{
			Console.WriteLine("Create ArcherCreator!");
		}
		
		public Unit Create(string unitName)
		{
			unitName = unitName.ToLower();
			
			switch( unitName )
			{
			case "archer":
				return new Archer( unitName );
			case "musketier":
				return new Musketier( unitName );
			default:
				return null;
			}
		}
	}
}

