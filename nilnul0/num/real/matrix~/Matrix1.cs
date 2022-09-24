using System;
using System.Collections.Generic;
using nilnul.num.tuple;
using nilnul.num.vector;

namespace nilnul.num.matrix._1
{
	public partial class Matrix
	{
		private double[,] _elements;

		public double[,] elments2
		{
			get
			{
				return _elements;	//this is a copy of the addres. So it can change the value, but not the structure. Note the array's structure is immutable
			}
			set
			{
				_init(value);
			}

		}
		private void _initEmpty()
		{
			this._elements = new double[0, 0];

		}

		private void _init(double[,] a)
		{
			//this.elements=new double[a.GetUpperBound(0), a.GetUpperBound(1)];
			if (a == null || a.GetLongLength(0) == 0 || a.GetLongLength(1) == 0)
			{
				_initEmpty();
				return;
			}

			this._elements = a;

		}
		public Matrix()
		{
			_initEmpty();
		}
		public Matrix(double[,] a)
		{
			//this.elements=new double[a.GetUpperBound(0), a.GetUpperBound(1)];
			if (a == null || a.GetLongLength(0) == 0 || a.GetLongLength(1) == 0)
			{
				_initEmpty();
				return;
			}

			this._elements = a;
		}

		public void add(long augend, long addend)
		{
			op.Gaussian.Add(_elements, augend, addend, 1);


		}

		public void add(long augend,long addend,double scale) {
			op.Gaussian.Add(_elements, augend, addend, scale);

		
		}
		public void swapRows(long augend, long addend)
		{

			op.Gaussian.Swap(_elements, augend, addend);

		}

		public void scale(double scale)
		{
			op.ScaleX.Eval_void(_elements, scale);

		}


		public Matrix(IEnumerable<IEnumerable<double>> e)
		{

		}





		public override string ToString()
		{
			string r = "";
			r += "Matrix{";
			for (int i = 0; i < this.rowsCount; i++)
			{
				r += "{";
				for (int j = 0; j < this.columnsCount; j++)
				{

					r += this._elements[i, j];
					r += ",";

				}
				r += "}";
				r += ",";

			}
			r += "}";
			return r;
		}

		public bool isEmpty
		{
			get
			{
				return _elements.GetLongLength(0) == 0;
			}
		}

		public Dimension dimension
		{
			get
			{
				return new Dimension(_elements.GetLongLength(0), _elements.GetLongLength(1));
			}
		}

		public Matrix remain(int i, int j)
		{
			//check whether i, j is in the subfix.
			if (i < 0 || i > this._elements.GetUpperBound(0))
			{
				throw new Exception("i is not in the range of the rows of the matrix.");
			}
			if (j < 0 || j > this._elements.GetUpperBound(1))
			{
				throw new Exception("j is not in the range of the columns of the matrix.");
			}
			double[,] d = new double[this.rowsCount - 1, this.columnsCount - 1];
			for (int k = 0; k < this.rowsCount; k++)
			{
				for (int l = 0; l < this.columnsCount; l++)
				{
					if (k < i && l < j)
					{
						d[k, l] = this._elements[k, l];
					}
					if (k < i && l > j)
					{
						d[k, l - 1] = this._elements[k, l];
					}
					if (k > i && l < j)
					{
						d[k - 1, l] = this._elements[k, l];
					}
					if (k > i && l > j)
					{
						d[k - 1, l - 1] = this._elements[k, l];
					}

				}
			}
			return new Matrix(d);

		}
		public bool isSquare()
		{
			if (this.isEmpty)
			{
				return true;
			}
			else if (this.rowsCount == this.columnsCount)
			{
				return true;
			}
			else { return false; }
		}






		public long rowsCount
		{
			get
			{
				return this._elements.GetLongLength(0);
			}
		}
		public long columnsCount
		{
			get
			{

				return this._elements.GetLongLength(1);
			}
		}


		public IEnumerable<double> row_IEnumerable(int column)
		{
			for (int i = 0; i <= this.rowsCount; i++)
			{
				yield return _elements[i, column];

			}
		}
		public IEnumerable<double> col_IEnumerable(int row)
		{
			for (int i = 0; i <= this.columnsCount; i++)
			{
				yield return _elements[row, i];

			}
		}

		public double[,] elementsToArray
		{

			get
			{
				return _elements.Clone() as double[,];
			}
		}




		public IEnumerable<IEnumerable<double>> elements
		{

			get
			{
				for (int i = 0; i < rowsCount; i++)
				{
					yield return row_IEnumerable(i);

				}
			}
		}






		public Vector row(int j)
		{

			double[] t = new double[_elements.GetUpperBound(1) + 1];
			for (int i = 0; i <= _elements.GetUpperBound(1); i++)
			{
				t[i] = _elements[j, i];

			}
			return new Vector(t, true);

		}

		public static Matrix operator /(Matrix m, double dd)
		{

			double[,] d = new double[m.rowsCount, m.columnsCount];
			for (int i = 0; i < m.rowsCount; i++)
			{
				for (int j = 0; j < m.columnsCount; j++)
				{
					d[i, j] = m._elements[i, j] / dd;
				}
			}
			return new Matrix(d);
		}
		public Vector column(int j)
		{

			double[] t = new double[_elements.GetUpperBound(0) + 1];
			for (int i = 0; i <= _elements.GetUpperBound(0); i++)
			{
				t[i] = _elements[i, j];

			}
			return new Vector(t);
		}
		public static Matrix operator *(Matrix m1, Matrix m2)
		{
			if (m1.columnsCount != m2.rowsCount)
			{
				throw new Exception("columns count of first matrix should equal to second matrix.");
			}

			long m = m1.rowsCount, n = m2.columnsCount;
			double[,] d = new double[m, n];
			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
				{
					d[i, j] = m1.row(i) * m2.column(j);
				}
			}
			return new Matrix(d);

		}

		public static Vector operator *(Matrix m, Vector v)
		{

			//check m.col.count=v.row.count
			if (m.columnsCount != v.components.Length)
			{
				throw new Exception("Matrix's column count != Vector.count");
			}
			double[] t = new double[m.rowsCount];
			for (int i = 0; i < m.rowsCount; i++)
			{
				t[i] = m.row(i) * v;
			}
			return new Vector(t);
		}


	}

}
