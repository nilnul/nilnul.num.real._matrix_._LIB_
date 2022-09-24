namespace nilnul.num.real.matrix_.square_
{
	/// <summary>
	/// equiv to rankful
	/// </summary>
	public class Invertible4dbl
		:
		square.vow.ee_.VowNeo4Dbl<square.be_.invertible.Vow>
		,
		square_.IInvertible
	{
		public Invertible4dbl(Square4dbl val) : base(val)
		{
		}

		public Invertible4dbl(double[,] vs):this(new Square4dbl(vs) )
		{
		}
	}
}
