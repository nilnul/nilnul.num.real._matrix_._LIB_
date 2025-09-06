namespace nilnul.num.real.matrix_.vacant_
{
	/// <summary>
	///	eg:
	///		[[]], a single one of rows, which is empty cllection of cells. this is 1*0, not no rows, but no cols; this is 1*0. it's unsqure and not <see cref="matrix.rows.be_.IIndependent"/>
	/// eg:
	///		[[],[]], two empty rows. this is 2*0;
	///	eg:
	///		[], 0 empty rows. this is 0*0. This is <see cref="matrix.rows.be_.IIndependent"/>
	///	;
	///	represented by:
	///		r[rows,0]
	///	
	/// </summary>
	/// <see cref="num.real.matrix.be_.IVacant"/>
	/// alias:
	///		freezer
	///		collapse
	///			, col lapse
	///		columnless
	///		noncol
	///		noncols
	public interface INoCols:IVacant
		//,
		//obj.matrix_.ICol
    {
    }

}
