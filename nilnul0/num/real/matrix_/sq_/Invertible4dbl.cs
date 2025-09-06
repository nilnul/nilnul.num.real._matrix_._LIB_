namespace nilnul.num.real.matrix_.sq_
{
	/// <summary>
	/// equiv to rankful
	/// </summary>
	public class Invertible4dbl
		:
		sq.vow.ee_.VowNeo4Dbl<sq.be_.invertible.Vow>
		,
		sq_.IInvertible
	{
		public Invertible4dbl(Square4dbl val) : base(val)
		{
		}

		public Invertible4dbl(double[,] vs):this(new Square4dbl(vs) )
		{
		}
	}
}
