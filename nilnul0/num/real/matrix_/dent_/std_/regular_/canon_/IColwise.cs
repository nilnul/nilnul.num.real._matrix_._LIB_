namespace nilnul.num.real.matrix_.dent_.std_.canon_
{
	/// <summary>
	/// when the transpose is <see cref="IRowwise"/>.
	/// 
	/// there might be some redundant nil cols.
	/// eg:
	///		[	1,0,0, 0,0;
	///			0,1,0, 0, 0;
	///		]
	/// eg:
	///		[	1,0,0, 0,0;
	///			0,1,0, 0, 0;
	///			0,0,0,0,0 
	///		]
	///		
	/// eg:
	///		[	1,0,0
	///			0,1,0
	///			0,0,0
	///			0,1,0
	///			0,0,0
	///		]
	///			,which is not rowwise.
	///		
	/// exclude:
	///		[	1,0,0, 0,0;
	///			0,1,0, 1, 0;
	///			0,0,0,0,0 
	///		], which is <see cref="IRowwise"/>
	///		
	///		
	/// </summary>
	public interface IColwise
	{
	}

}
