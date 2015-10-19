using System;
namespace DesignPatternPractice
{
	public interface Creator
	{
		Unit Create(string unitName);
	}
}