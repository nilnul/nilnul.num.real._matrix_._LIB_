using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.be_
{
	/// <summary>
	/// there is a one, and all others are zero.
	/// </summary>
	static public class _IdealX
	{
		static public bool _Be_0str(
			in IEnumerator<Q> reals
		)
		{

			while (reals.MoveNext())
			{
				var c = reals.Current;
				if (c == 0)
				{
					continue;
				}
				if (c!=1)
				{
					return false;
				}

				while (reals.MoveNext())
				{
					if (reals.Current != 0)
					{
						return false;
					}

				}
				return true;

			}
			return false; /// when the str is empty. for 0d, there is 0 ideals. or when the str is all nils;


		}


		/// <summary>
		/// </summary>
		/// <returns></returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _Be_0str(
			in IEnumerable<Q> reals
		)
		{
			return _Be_0str(reals.GetEnumerator());
		}
	}


}
