﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x86.Intrinsic
{
	/// <summary>
	/// Representations a SyncCompareAndSwap Intrinsic
	/// </summary>
	internal sealed class SyncCompareAndSwap : IIntrinsicPlatformMethod
	{
		void IIntrinsicPlatformMethod.ReplaceIntrinsicCall(Context context, MethodCompiler methodCompiler)
		{
			var pointer = context.Operand1;
			var oldval = context.Operand2;
			var newval = context.Operand3;
			var result = context.Result;

			var eax = Operand.CreateCPURegister(methodCompiler.TypeSystem.BuiltIn.U4, GeneralPurposeRegister.EAX);
			var v1 = methodCompiler.CreateVirtualRegister(methodCompiler.TypeSystem.BuiltIn.U4);

			// Compare EAX with r/m32. If equal, ZF is set and r32 is loaded into r/m32.
			// Else, clear ZF and load r/m32 into EAX.

			context.SetInstruction(X86.Mov32, eax, oldval);
			context.AppendInstruction(X86.Mov32, v1, newval);
			context.AppendInstruction(X86.Lock);
			context.AppendInstruction(X86.CmpXChgLoad32, eax, eax, pointer, methodCompiler.ConstantZero, v1);
			context.AppendInstruction(X86.SetEqual, result);
		}
	}
}
