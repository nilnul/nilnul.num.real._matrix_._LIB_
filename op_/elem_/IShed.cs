namespace nilnul.num.real.matrix.op_.elem_
{
	/// <see cref="num.real.matrix_.sq_.diag_.dilute_"/>
	/// <summary>
	/// divide only one row by a number, which has to be unnil as it is now a divisor.
	/// eg:
	///		[ 0 , 2, 3]
	///		=> [ 0, 1,3/2]
	/// </summary>
	/// alias:
	///		shaft
	///		shy
	///		shed, four letters like <see cref="op_.ISwap"/>
	///			,dilute
	///		shred
	///		
	///		stretch, in 1dimension, not all dimensions as in <see cref="real.matrix.op_.IShred"/>
	///		stray
	///		sift
	///		<see cref="op_._indent.gauss_.IShed"/>
	///		transvections	
	///		shear
	/// 
	///	vs:
	///		divide all cels:<see cref="op_.IShred"/>
	///		skew,<see cref="ISkew"/>
	///		
	public interface IShed:matrix.row.op_.IShed //.IOp
	{
	}



}
