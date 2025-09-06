namespace nilnul.num.real.matrix.be_
{
	/// <summary>
	/// upper triangle.
	/// eg:
	///		E[]
	///		E[0*1]
	///		E[0*2]
	///		
	///		[0]
	///		[0,0]
	///		[0,1]
	///		
	///		[0,1;
	///		 0,0]
	///		 
	///		[0,1;
	///		 0,0;
	///		 0,0
	///		 ]
	///		 
	/// </summary>
	/// <remarks>
	/// used in <see cref="matrix.equat_.linear_.IIndent"/>
	/// </remarks>
	/// alias:
	///		echelon
	///		indent
	///			,to see if it's independent
	public interface IIndent:matrix.IBe { }
}
