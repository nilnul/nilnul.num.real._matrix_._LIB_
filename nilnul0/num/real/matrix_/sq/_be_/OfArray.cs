using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq._be_
{
	/// <summary>
	/// the array will be vowed;
	/// </summary>
	public interface OfArray4dblI
		:
		nilnul.obj.BeI_ofIn<Square4dbl>
		,
		sq.Be4dblI1
	{
	}

	public abstract class OfArray4dblA
		: OfArray4dblI
		,
		_be_._ofArr_._AssumeSquareI
	{
		

		public bool be(in Square4dbl val)
		{
			return _be_0square(
				//in
				val.ee
			);
		}

		public abstract bool _be_0square(in double[,] square);
	}


}
