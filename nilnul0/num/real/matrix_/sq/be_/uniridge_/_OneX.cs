using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq.be_.uniridge_
{
	static public class _OneX{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _IsUniridgeOne_0sq(
			in Q[,] square	
		) {

			return 	nilnul.num.real.matrix_.sq._RidgeX._Ridge_0square(square).All(a=>a==1);
		}
	}


}
