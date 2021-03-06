// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.Framework.Transform.Auto.Simplification
{
	/// <summary>
	/// Compare32x64SameAndEqual
	/// </summary>
	public sealed class Compare32x64SameAndEqual : BaseTransformation
	{
		public Compare32x64SameAndEqual() : base(IRInstruction.Compare32x64)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			var condition = context.ConditionCode;

			if (!(context.ConditionCode == ConditionCode.Equal || context.ConditionCode == ConditionCode.GreaterOrEqual || context.ConditionCode == ConditionCode.LessOrEqual || context.ConditionCode == ConditionCode.UnsignedGreaterOrEqual || context.ConditionCode == ConditionCode.UnsignedLessOrEqual))
				return false;

			if (!AreSame(context.Operand1, context.Operand2))
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var e1 = transformContext.CreateConstant(To64(1));

			context.SetInstruction(IRInstruction.Move64, result, e1);
		}
	}
}
