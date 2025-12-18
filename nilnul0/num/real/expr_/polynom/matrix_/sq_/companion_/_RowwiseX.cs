using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.num.real.expr_._algebraic;
using nilnul.obj.expr.var;
using System.Linq.Expressions;
using nilnul.obj.stream_.slider.to_;
using nilnul.txt.be_;
using System.Diagnostics.Contracts;
using nilnul.num.real.expr_;
using nilnul.num.real.expr_.polynom.op_;
using P = nilnul.num.real.expr_.Algebraic;


namespace nilnul.num.real.expr_.polynom.matrix_.sq_.companion_
{
	/// 
	/// <summary>
	/// note:
	///		re:<see cref="num.real.matrix_.sq._eigen.polynom.ICompanion"/>, <see cref="num.real.expr_.polynom_.univar_.std.to_.companion_._ColumnwiseX"/>
	///	, here the matrix is:
	///		rowwise
	///		, it's negated
	///		, the var as a scaler is added
	/// </summary>
	/// <remarks>
	/// here as the coef is not constant, but var, the resulted is not a univar, but a multivar polynomial;
	/// the cel is var or constant, or linear; in other words, the cel is <see cref="real.expr_.polynom_.ISubliminary"/>
	/// </remarks>
	/// <see cref="polynom_.univar_.std.to_.companion_._ColumnwiseX"/>
	static public class _RowwiseX
	{



		/// <summary>
		/// eg:
		///		[
		///			x,	-1,		0,...	,	0
		///			0,	x,		-1,	...,	0
		///			0,	0,		x,	-1,...,	0
		///			...
		///			a0,a1,		a2,...	x+a[n-1]
		///		]
		/// </summary>
		/// <remarks>
		///  the determinant is :
		/// a[0] + a[1] x + a[2] x^2 + ...+ a[n-1] x^(n-1) + x^n
		/// </remarks>
		/// <param name="n"></param>
		/// <param name="x"></param>
		/// <param name="a">
		/// a[0] + a[1] x + a[2] x^2 + ...+ a[n-1] x^(n-1) + x^n
		/// </param>
		static public P[,] ToMatrix(Var1[] a, Var1 x )
		{
			//var a = Enumerable.Range(0, (int)n).Select(
			//	i=>  new nilnul.num.real.expr_.Var1($"a{i+1}") 
			//).ToArray();
			var n = a.Length;

			var m = nilnul.num.real.expr_.polynom.matrix_.sq_._NilX.Generate(n);



			/// supdiag:
			/// 
			for (int i = 0; i < n-1; i++)
			{
				m[i, i+1] = -1;
			}



			/// the last row:
			/// 
			for (int c = 0; c < n; c++)
			{
				m[n-1, c] = a[c];
			}



			for (var i = 0; i<n; i++)
			{
				m[i, i] += x;
			}



			///the determ is the polynomial:
			/// 
			/// the inferred ans 
			///
			/// by col0:
			/// 
			///		x* D(n-1)
			///		+ (-1)^(n-1) *(-1)^(n+1) a[0]
			///		= xD(n-1) +a[0]
			///		
			/// ;
			///  D0 = 1x^0 +0
			///		,which is <see cref="num.real.expr_.polynom_.univar_.IStd"/>
			///  D1(0) =  x (D0) +a0 = x+ a0 
			///  D2= x D1(1) +a0 =  x(x+a1) +a0
			///		= x^2 + a1 x + a0
			///  D3 = x D2(2) + a0 
			///		= x ( x( x+a2) +a1) +a0
			///		= x^3 + a2 x^2 + a1 x + a0
			///		
			///  ...
			///  D[n] = x^n + a[n-1] x^(n-1) + ... + a[0]
			///
			/// <see cref="num.real.expr_.polynom_.univar_.std.to_._CompanionMatrixX"/>
			/// 

			return m;


		}


		/// <summary>
		/// eg:
		///		[
		///			x,	-1,		0,...	,	0
		///			0,	x,		-1,	...,	0
		///			0,	0,		x,	-1,...,	0
		///			...
		///			a0,a1,		a2,...	x+a[n-1]
		///		]
		/// </summary>
		/// <remarks>
		///  the determinant is :
		/// a[0] + a[1] x + a[2] x^2 + ...+ a[n-1] x^(n-1) + x^n
		/// </remarks>
		/// <param name="n"></param>
		/// <param name="x"></param>
		/// <param name="a">
		/// a[0] + a[1] x + a[2] x^2 + ...+ a[n-1] x^(n-1) + x^n
		/// </param>
		static public P[,] ToMatrix(RealI[] a, Var1 x)
		{
			var n = a.Length;

			var m = nilnul.num.real.expr_.polynom.matrix_.sq_._NilX.Generate(n);


			/// supdiag:
			/// 
			for (int i = 0; i < n-1; i++)
			{
				m[i, i+1] = -1;
			}

			/// the last row:
			/// 
			for (int c = 0; c < n; c++)
			{
				m[n-1, c] = a[c].ToImpl();
			}

			for (var i = 0; i<n; i++)
			{
				m[i, i] += x;
			}

			return m;
		}

	}
}
