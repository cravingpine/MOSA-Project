// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.Framework.Transform.Auto.StrengthReduction
{
	/// <summary>
	/// MulSigned32ByOne
	/// </summary>
	public sealed class MulSigned32ByOne : BaseTransformation
	{
		public MulSigned32ByOne() : base(IRInstruction.MulSigned32)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (!context.Operand2.IsResolvedConstant)
				return false;

			if (context.Operand2.ConstantUnsigned64 != 1)
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var t1 = context.Operand1;

			context.SetInstruction(IRInstruction.Move32, result, t1);
		}
	}

	/// <summary>
	/// MulSigned32ByOne_v1
	/// </summary>
	public sealed class MulSigned32ByOne_v1 : BaseTransformation
	{
		public MulSigned32ByOne_v1() : base(IRInstruction.MulSigned32)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (!context.Operand1.IsResolvedConstant)
				return false;

			if (context.Operand1.ConstantUnsigned64 != 1)
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var t1 = context.Operand2;

			context.SetInstruction(IRInstruction.Move32, result, t1);
		}
	}
}
