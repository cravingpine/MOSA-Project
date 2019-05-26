// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x64.Instructions
{
	/// <summary>
	/// Lock
	/// </summary>
	/// <seealso cref="Mosa.Platform.x64.X64Instruction" />
	public sealed class Lock : X64Instruction
	{
		public override int ID { get { return 443; } }

		internal Lock()
			: base(0, 0)
		{
		}

		public override bool HasUnspecifiedSideEffect { get { return true; } }

		public override void Emit(InstructionNode node, BaseCodeEmitter emitter)
		{
			System.Diagnostics.Debug.Assert(node.ResultCount == 0);
			System.Diagnostics.Debug.Assert(node.OperandCount == 0);

			emitter.OpcodeEncoder.AppendByte(0xF0);
		}
	}
}
