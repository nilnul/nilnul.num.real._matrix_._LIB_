namespace nilnul.num.real.matrix_.sq.calc_.binary_.dif_
{
	/// <summary>
	/// [
	///		0,1,1
	///		1,0,1
	///		1,1,0
	/// ]
	/// </summary>
	static public class _UnioneCanonX
	{
		static public Q4[,] OfWidth(int x)
		{
			var t = matrix_.sq_.unival_._OmniOneX.Generate_0wide(x);

			nilnul.num.real.matrix.bi_._SubtractX._Deduce_1equisize(
				 t
				,
				matrix_.sq_._CanonicalX.Generate8quotient(x)
			);
			return t;



		}
	}

}
