namespace nilnul.num.real.matrix_.sq_.invertible.op_
{
	/// <summary>
	/// We can find at least one such B by <see cref="_invert_.by_.IAdjugate"/>.
	///  That means there exist such invert. But is it unique?
	///  
	/// Given A,
	/// , Suppose we can find another B such that AB=I
	/// , then <see cref="real.matrix_.sq.re_.reciprocal.theorem_.ISwappable"/>, so BA =I
	/// , so B is a inverse.
	///   BA /A = I /A
	///   ,hence B =  1/A. arises the condradiction where we assume B is different from 1/A
	///   
	/// </summary>
	/// <remarks>
	/// <see cref="nilnul.num.real.matrix_.sq_.invertible.op_.unary_.Invert"/>
	/// </remarks>
	public interface IInvert { }
}
