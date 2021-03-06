// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.Framework.Transform.Auto.Simplification
{
	/// <summary>
	/// Compare64x32SameAndNotEqual
	/// </summary>
	public sealed class Compare64x32SameAndNotEqual : BaseTransformation
	{
		public Compare64x32SameAndNotEqual() : base(IRInstruction.Compare64x32)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			var condition = context.ConditionCode;

			if (!(context.ConditionCode == ConditionCode.NotEqual || context.ConditionCode == ConditionCode.Greater || context.ConditionCode == ConditionCode.Less || context.ConditionCode == ConditionCode.UnsignedGreater || context.ConditionCode == ConditionCode.UnsignedLess))
				return false;

			if (!AreSame(context.Operand1, context.Operand2))
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var e1 = transformContext.CreateConstant(To32(0));

			context.SetInstruction(IRInstruction.Move32, result, e1);
		}
	}
}
