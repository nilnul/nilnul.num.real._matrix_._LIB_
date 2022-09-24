namespace nilnul.num.real
{
	public class Matrix4dbl :
		nilnul.obj.Matrix<double>
		,
		IMatrix
	{
		public Matrix4dbl(double[,] val) : base(val)
		{
		}
		static public implicit operator Matrix4dbl(double[,] a) {
			return new Matrix4dbl(a);
		}
		static public implicit operator double[,](Matrix4dbl a) {
			return a;
		}

		static public Matrix4dbl operator +(Matrix4dbl a, Matrix4dbl b) {

			return num.real.matrix.co_.plusable._PlusX.Add(a, b);
		}

		static public Matrix4dbl operator *(Matrix4dbl a, Matrix4dbl b) {

			return num.real.matrix.co_.multible._MultiX.Multi(a, b);
		}



	}
}
