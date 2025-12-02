namespace nilnul.num.real.matrix_.sq_.triag_.upper_
{


	/// <see cref="real.matrix_.sq_.canon.to_.upper_.ISlant"/>
	/// <summary>
	/// c[i] += sum(c[j]) where j lt i, for a <see cref="sq_.triag_.IUpper"/>; that means c[i] would have some(not only one) values above the diagonal.
	/// <see cref="sq_.basic_.skews_.colwise_.ISlant"/>
	/// ;
	/// eg:
	///		[
	///			1,0,2
	///			0,2,3
	///			0,0,4
	///		
	///		]
	/// </summary>
	/// 
	public interface IFrobenius
		:matrix_.sq_.triag_.IUpper
    {
    }



}
