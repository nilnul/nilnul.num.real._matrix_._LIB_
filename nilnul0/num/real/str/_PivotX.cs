using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str
{
	/// <summary>
	/// find the first unnil element. the result is <see cref="obj.IOpt"/> of the index.
	/// </summary>
	/// alias:
	/// 

	static public class _PivotX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int Pivot(
			this Q[] reals	
		) {
			return Array.FindIndex(reals, x=> x!=0);
		}

		static public int Pivot(
			this IEnumerator<Q> reals	
		) {
			var i = 0;
			while (reals.MoveNext())
			{
				if (reals.Current ==0)
				{
					i++;
					continue;
				}
				return i;
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int Pivot(
			this IEnumerable<Q> reals	
		) {
			return Pivot(reals.GetEnumerator() );
		}




		/// <summary>
		/// </summary>
		/// <returns></returns>
		static public double PivotValue(
			this IEnumerable<double> reals	
		) {
			var x = reals.SkipWhile(x => x ==0).Take(1);
			if (x.Any()) {
				return x.First();
			}
			return 0;
		}


		static public Q PivotValue(
			this IEnumerable<Q> reals	
		) {
			var x = reals.SkipWhile(x => x ==0).Take(1);
			if (x.Any()) {
				return x.First();
			}
			return 0;
		}







	}


}
