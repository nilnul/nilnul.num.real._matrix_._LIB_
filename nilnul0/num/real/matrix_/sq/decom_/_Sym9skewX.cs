namespace nilnul.num.real.matrix_.sq.decom_
{
	static public class _Sym9skewX
	{
		/// <summary>
		/// <see cref="real.matrix_.sq.be_.SkewSymmetric"/>
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		static public (Q4[,] sym, Q4[,] skew) _DecomAsSymmetric9skewsym_0sq(Q4[,] m)
		{
			var t = num.real.matrix.op_.Transpose.Op(m);
			var added = num.real.matrix.bi_._AddX._Add_1isosize(m, t);
			nilnul.num.real.matrix.op_._ScaleX.Dilute(
				added, 2
			);


			var minused = num.real.matrix.bi_._SubtractX._Minus_1equisize(m, t);

			nilnul.num.real.matrix.op_._ScaleX.Dilute(
				minused, 2
			);

			return (
				added
				,
				minused
			);
		}
	}
}
