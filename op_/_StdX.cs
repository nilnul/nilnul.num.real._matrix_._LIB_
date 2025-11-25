namespace nilnul.num.real.matrix.op_
{
	static public class _StdX
	{
		static public void Std(ref Q[,] m) {
			 real.matrix.op_.dent_.echelon_._VentX.Vent(ref m); /// the rowwise transoperation is discarded

			real.matrix_.vent.op_._StdX._StdIntoColwise_0vent(ref m);

		}
	}


}
