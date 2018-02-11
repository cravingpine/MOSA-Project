// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x86.Instructions
{
	/// <summary>
	/// BranchUnsignedLessThan
	/// </summary>
	/// <seealso cref="Mosa.Platform.x86.X86Instruction" />
	public sealed class BranchUnsignedLessThan : X86Instruction
	{
		public override string AlternativeName { get { return "JB"; } }

		public static readonly byte[] opcode = new byte[] { 0x0F, 0x82 };

		internal BranchUnsignedLessThan()
			: base(0, 0)
		{
		}

		public override FlowControl FlowControl { get { return FlowControl.ConditionalBranch; } }

		public override bool ThreeTwoAddressConversion { get { return false; } }

		public override BaseInstruction GetOpposite()
		{
			return X86.BranchUnsignedGreaterOrEqual;
		}

		public override void Emit(InstructionNode node, BaseCodeEmitter emitter)
		{
			System.Diagnostics.Debug.Assert(node.ResultCount == 0);
			System.Diagnostics.Debug.Assert(node.OperandCount == 0);
			System.Diagnostics.Debug.Assert(node.BranchTargets.Count >= 1);
			System.Diagnostics.Debug.Assert(node.BranchTargets[0] != null);

			emitter.Write(opcode);
			(emitter as X86CodeEmitter).EmitRelativeBranchTarget(node.BranchTargets[0].Label);
		}
	}
}

