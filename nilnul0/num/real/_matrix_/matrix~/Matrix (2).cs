using System;

namespace math
{
	public class Matrix
	{
		public double[,] elements;
		public bool transposed=false;
		public bool empty=false;
		public Matrix()
		{
			this.empty=true;
		}
		public Matrix(double[,] a)
		{
			//this.elements=new double[a.GetUpperBound(0), a.GetUpperBound(1)];
			this.elements=a;

		}
		public override string ToString()
		{
			string r="";
			r+="Matrix{";
			for(int i=0;i<this.rowsCount();i++){
				r+="{";
				for(int j=0;j<this.columnsCount();j++){
					
					r+=this.elements[i,j];
					if(j<this.columnsCount()-1){
						r+=",";
					}
					
				}
				r+="}";
				if(i<this.rowsCount()-1){
					r+=",";
				}

			}
					  r+="}";
			return r;
		}

		public double determinant()
		{
			if(this.rowsCount()!=this.columnsCount())
			{
				throw new Exception("rows count must be the same as columns count to compute determinant.");
			}
			if(this.empty) return 0;
			else if(this.rowsCount()==1)
			{
				return this.elements[0,0];
			}
			else
			{
				double t=0;
				double tt=0;
				for(int i=0;i<this.columnsCount();i++)
				{
					tt=this.elements[0,i]*remain(0,i).determinant();
					if(i%2==1)
					{
						t-=tt;
					}
					else
					{
						t+=tt;
					}
				} 
				return t;
			}
			
		}
		public Matrix remain(int i, int j)
		{
			//check whether i, j is in the subfix.
			if(i<0||i>this.elements.GetUpperBound(0))
			{
				throw new Exception("i is not in the range of the rows of the matrix.");
			}
			if(j<0||j>this.elements.GetUpperBound(1))
			{
				throw new Exception("j is not in the range of the columns of the matrix.");
			}
			double[,] d=new double[this.rowsCount()-1,this.columnsCount()-1];
			for(int k=0;k<this.rowsCount();k++)
			{
				for(int l=0;l<this.columnsCount();l++)
				{
					if(k<i && l<j)
					{
						d[k,l]=this.elements[k,l];
					}
					if(k<i && l>j)
					{
						d[k,l-1]=this.elements[k,l];
					}
					if(k>i && l<j)
					{
						d[k-1,l]=this.elements[k,l];
					}
					if(k>i && l>j)
					{
						d[k-1,l-1]=this.elements[k,l];
					}
					
				}
			}
			return new Matrix(d);
			
		}
		public bool isSquare(){
			if(this.empty)
			{
				return true;
			}
			else if(this.rowsCount()==this.columnsCount())
			{
				return true;
			}
			else{return false;}
		}
		
		public Matrix asterisk()
		{
			if(!this.isSquare())
			{
				throw new Exception("asterisk cannot be applied on a non-square matrix.");
			}
			double[,] d=new double[this.rowsCount(),this.columnsCount()];
			for(int i=0;i<this.rowsCount();i++){
				for(int j=0;j<this.columnsCount();j++){
					double t;
					if((i+j)%2==0)
					{
						t=this.remain(i,j).determinant();
					}
					else{
						t=-this.remain(i,j).determinant();
					}
					d[i,j]=t;
				}
			}
			return new Matrix(d);
		}

		public Matrix(Vector[] vs,bool transposed)
		{
		}
		public Matrix transpose()
		{
			this.transposed=!transposed;
			return this;
		}
		public Matrix transpose2(){
			double[,] d=new double[this.columnsCount(),this.rowsCount()];
			for(int i=0;i<this.rowsCount();i++){
				for(int j=0;j<this.columnsCount();j++){
					d[j,i]=this.elements[i,j];
				}
			}
			return new Matrix(d);
				  }
		public int rowsCount()
		{
			if(transposed)
			{
				return this.elements.GetUpperBound(1)+1;
			}
			return this.elements.GetUpperBound(0)+1;
		}
		public int columnsCount()
		{
			if(transposed)
			{
				return this.elements.GetUpperBound(0)+1;
			}
			return this.elements.GetUpperBound(1)+1;
		}
		public Vector row(int j)
		{
			if(transposed) return column(j);
			double[] t=new double[elements.GetUpperBound(1)+1];
			for(int i=0;i<=elements.GetUpperBound(1);i++)
			{
				t[i]=elements[j,i];

			}
			return new Vector(t,true);

		}
		public Matrix reverse(){
			if(this.determinant()==0){
				throw new Exception("When reversed, the determinant of the matrix is 0.");
			}
			return this.asterisk()/this.determinant();
		}
		public static Matrix operator /(Matrix m,double dd){
			double[,] d=new double[m.rowsCount(),m.columnsCount()];
			for(int i=0;i<m.rowsCount();i++){
				for(int j=0;j<m.columnsCount();j++){
					d[i,j]=m.elements[i,j]/dd;
				}
			}
			return new Matrix(d);
		}
		public Vector column(int j)
		{
			if(transposed){return row(j);}
			double[] t=new double[elements.GetUpperBound(0)+1];
			for(int i=0;i<=elements.GetUpperBound(0);i++)
			{
				t[i]=elements[i,j];

			}
			return new Vector(t);
		}
		public static Matrix operator *(Matrix m1,Matrix m2)
		{
			if(m1.columnsCount()!=m2.rowsCount())
			{
				throw new Exception("columns count of first matrix should equal to second matrix.");
			}

			int m=m1.rowsCount(),n=m2.columnsCount();
			double[,] d=new double[m,n];
			for(int i=0;i<m;i++)
			{
				for(int j=0;j<n;j++)
				{
					d[i,j]=m1.row(i)*m2.column(j);
				}
			}
			return new Matrix(d);
					  
		}
		
		public static Vector operator *(Matrix m, Vector v)
		{

			//check m.col.count=v.row.count
			if(m.columnsCount()!=v.components.Length)
			{
				throw new Exception("Matrix's column count != Vector.count");
			}
			double[] t=new double[m.rowsCount()];
			for(int i=0;i<m.rowsCount();i++)
			{
				t[i]=m.row(i) * v;
			}
			return new Vector(t);
		}
	}
	
}
