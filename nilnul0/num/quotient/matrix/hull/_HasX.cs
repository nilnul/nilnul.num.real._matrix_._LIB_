using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.matrix.hull
{
	static public class _HasX
	{
		/// <summary>
		/// not whether the vec is in the rows, but in the hull.
		/// </summary>
		/// <remarks>
		/// whether vec can be linearly combinated by the matrix rows;
		/// </remarks>
		/// <param name="matrix"></param>
		/// <param name="vec"></param>
		/// <returns></returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _Has_1equiwide(Q4[,] matrix, Q4[] vec) {

			///<see cref="real.matrix.re_._EquiHullX"/>
			///<see cref="nilnul.num.real.matrix.co_.equiwide.be_._equihull_.by_._ByIndepVentX"/>
			///
			/// <see cref="num.quotient.matrix.op_.colwise"/>
			/// <see cref="num.real.matrix.op_.colwise_."/>
			/// <see cref="num.real.matrix_.trape_.left_.colly_.cascade_.IParagon"/>
			///
			/// or see if the Ax =b has solution, 
			/// ,<see cref="quotient.matrix.husk._HasX"/>
			/// 
			/// todo: <see cref="num.quotient.matrix.pred_.rudic_.univar_.IRowwise"/>

			return husk._HasX._Has_1equihigh(
				num.real.matrix.op_.Transpose.Op(matrix)
				,vec
				
			);
		}
	}
}
