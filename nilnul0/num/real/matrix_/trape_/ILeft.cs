namespace nilnul.num.real.matrix_.trape_
{
	/// <summary>
	/// all cells over the diagonal belt are 0
	/// ;
	/// eg:
	///		1,2
	///	eg:
	///		1,2,0
	///		3,4,5
	///	eg:
	///		1	0	0
	///		3	4	0
	///		,which is also <see cref="triag_.ILower"/>
	///	eg:
	///		1	0
	///		1	3
	///		2	3
	///	ex:
	///		0	0
	///		1	0
	///		2	3
	///		,wich is also <see cref="triag_.ILower"/>
	/// eg:
	///		[
	///			1	0	0
	///			2	3	0
	///			2	3	0
	///			2	4	5
	///		]
	/// eg:
	///		[
	///			1	4	0
	///			2	3	5
	///		]
	///		
	/// </summary>
	public interface ILeft:matrix_.ITrapezoidal
	{
	}



}
