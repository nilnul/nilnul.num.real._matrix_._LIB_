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
	{

		static private readonly Trace _Instance = new Trace();
		static public Trace Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Trace()
		{
		}

		public number.real.FuncCall call(MatrixI m)
		{
			return new FuncCall(Instance, new[] { m });
		}

		public number.real.ExprI eval(SquareI m)
		{
			number.real.ExprI r=new number.real.Rational( 0);
			for (int i = 0; i < m.colCount; i++)
			{
				r.Add(m[i, i]);
				
			}
			return r;
			
			
		}
	}
}
