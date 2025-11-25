namespace nilnul.num.real.matrix_
{
	///	/// 一般不说哪种标准型的话，指的应该是初等变换后得到的最简标准型，即左上角是一个单位阵，其余都是零元素。
	/// <summary>
	/// eg:
	/// 
	/// </summary>
	/// alias:
	///		chimney, where 'c' is also the initial letter of 'column"
	///			, meaning vertically, it's hollow
	///			, similar to canonical
	///		vent
	///			,vertical
	///			, with 0s, it can reach both sides to vent
	///		funnel
	///		hoist
	///		
	///		echelon
	///	vs:
	///		<see cref="matrix_.IVacant"/>
	///		
	public interface IVent:real.matrix_.dent_.echelon_.IPivotColAsBasis
	{
	}


}
