﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x86.Intrinsic
{
	/// <summary>
	///
	/// </summary>
	internal sealed class LockSet : IIntrinsicPlatformMethod
	{
		#region Methods

		/// <summary>
		/// Replaces the intrinsic call site
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="typeSystem">The type system.</param>
		void IIntrinsicPlatformMethod.ReplaceIntrinsicCall(Context context, BaseMethodCompiler methodCompiler)
		{
			Operand dest = context.Operand1;
			Operand value = context.Operand2;

			Operand v1 = methodCompiler.CreateVirtualRegister(dest.Type);
			Operand v2 = methodCompiler.CreateVirtualRegister(value.Type);
			Operand memory = Operand.CreateMemoryAddress(context.InvokeMethod.Signature.Parameters[1].ParameterType, v1, 0);

			context.SetInstruction(X86.Mov, v1, dest);
			context.AppendInstruction(X86.Mov, v2, value);
			context.AppendInstruction(X86.Mov, memory, v2);
		}

		#endregion Methods
	}
}
