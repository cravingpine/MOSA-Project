// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x86.Instructions
{
	/// <summary>
	/// Lgdt
	/// </summary>
	/// <seealso cref="Mosa.Platform.x86.X86Instruction" />
	public sealed class Lgdt : X86Instruction
	{
		internal Lgdt()
			: base(0, 1)
		{
		}

		public override bool HasIRUnspecifiedSideEffect { get { return true; } }

		public override bool ThreeTwoAddressConversion { get { return false; } }

		public override void Emit(InstructionNode node, BaseCodeEmitter emitter)
		{
			System.Diagnostics.Debug.Assert(node.ResultCount == DefaultResultCount);
			System.Diagnostics.Debug.Assert(node.OperandCount == DefaultOperandCount);

			StaticEmitters.EmitLgdt(node, emitter);
		}
	}
}

