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
namespace DesignPatternPractice
{
	public class Musketier: Unit
	{
		public Musketier (string name)
		{
			unitName = name;
			Console.WriteLine("Create Success Musketier");
		}

		public override void Move(int x, int y)
		{
			Console.WriteLine(string.Format("Musketier Move ({0}, {1})", x, y));
		}
	}
}

