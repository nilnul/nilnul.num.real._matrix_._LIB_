namespace nilnul.num.real.matrix_.sq.op_
{
	/// <summary>
	/// add to the diagonal cells. Don't touch other cells;
	/// </summary>
	/// 

	static public class _CrestX
	{

		static public void Crest(ref Q4[,] m, Q4 ridgeUp) {
			var n = m.GetLength(0);
			for (var i = 0; i < n; i++)
			{
				m[i, i] +=ridgeUp;
			}
		}
	}
}