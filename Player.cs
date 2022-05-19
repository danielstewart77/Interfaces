using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	/// <summary>
	/// Implements IPlayer
	/// Id is readonly and Name can be changed at any time by the user 
	/// </summary>
	public class Player : IPlayer
	{

		private readonly Guid _id = Guid.NewGuid();
		private string _name = "";
		public Guid Id { get { return _id; } }

		public string Name { get { return _name; } set { _name = value; } }

	}
}
