// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.Framework.Transform.Auto.ConstantFolding
{
	/// <summary>
	/// Convert64ToR8
	/// </summary>
	public sealed class Convert64ToR8 : BaseTransformation
	{
		public Convert64ToR8() : base(IRInstruction.Convert64ToR8)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (!IsResolvedConstant(context.Operand1))
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var t1 = context.Operand1;

			var e1 = transformContext.CreateConstant(ToR8(ToSigned64(t1)));

			context.SetInstruction(IRInstruction.MoveR8, result, e1);
		}
	}
}
