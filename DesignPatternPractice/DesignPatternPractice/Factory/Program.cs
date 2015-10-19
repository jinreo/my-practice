// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace DesignPatternPractice
{
	public class Program
	{
		static void Main(string[] args)
		{
			WarriorCraetor	warriorCreator = new WarriorCraetor();
			ArcherCreator	archerCreator = new ArcherCreator();

			List<Unit>		units = new List<Unit>();
			
			units.Add ( warriorCreator.Create("warrior") ); 
			units.Add ( archerCreator.Create("archer") ); 
			units.Add ( warriorCreator.Create("knight") ); 
			units.Add ( archerCreator.Create("musketier") ); 

			foreach( Unit unit in units )
			{
				unit.Move( 3, 5 );
			}
		}
	}
}
