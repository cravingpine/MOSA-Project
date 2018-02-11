// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x86.Instructions
{
	/// <summary>
	/// TestConst32
	/// </summary>
	/// <seealso cref="Mosa.Platform.x86.X86Instruction" />
	public sealed class TestConst32 : X86Instruction
	{
		public static readonly LegacyOpCode LegacyOpcode = new LegacyOpCode(new byte[] { 0xF7 } , 0x00);

		internal TestConst32()
			: base(0, 2)
		{
		}

		internal override void EmitLegacy(InstructionNode node, X86CodeEmitter emitter)
		{
			System.Diagnostics.Debug.Assert(node.ResultCount == 0);
			System.Diagnostics.Debug.Assert(node.OperandCount == 2);
			System.Diagnostics.Debug.Assert(node.Result == node.Operand1);
			System.Diagnostics.Debug.Assert(node.Result.IsCPURegister);
			System.Diagnostics.Debug.Assert(node.Operand1.IsCPURegister);

			emitter.Emit(LegacyOpcode, node.Operand1, node.Operand2);
		}
	}
}

