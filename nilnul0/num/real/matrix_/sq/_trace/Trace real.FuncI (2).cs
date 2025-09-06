using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.number.real;

namespace nilnul.math.linear.matrix
{
	/// <summary>
	/// the sum of all numbers in the diagonal from the upper left to lower right.
	/// </summary>
	public partial class Trace
		:number.real.FuncI
	{


		

		#region FuncI Members

		public FuncCallI call(IEnumerable<object> arguments)
		{
			if (arguments.Count()==1 && arguments.ElementAt(0) is Matrix)
			{
				return call((Matrix)(arguments.ElementAt(0)));

			}
			else
			{
				throw new Exception();
			}
		}

		#endregion




		
	}
}
