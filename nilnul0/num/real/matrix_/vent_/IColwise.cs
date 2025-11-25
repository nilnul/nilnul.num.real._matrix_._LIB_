namespace nilnul.num.real.matrix_.vent_
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
	///  <remarks>
	/// columnwisely speaking
	/// </remarks>
	/// alias:
	///		colly
	///		colwise

	public interface IColwise
	{
	}

}
