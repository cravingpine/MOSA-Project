// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x86.Instructions
{
	/// <summary>
	/// AdcConst
	/// </summary>
	/// <seealso cref="Mosa.Platform.x86.X86Instruction" />
	public sealed partial class AdcConst : X86Instruction
	{
		private static readonly LegacyOpCode legacyOpcode = new LegacyOpCode(new byte[] { 0x81, 0x02 });

		public AdcConst()
			: base(1, 2)
		{
		}

		public override void Emit(InstructionNode node, BaseCodeEmitter emitter)
		{
			EmitOpcode(node, emitter);
		}

		public override LegacyOpCode __legacyopcode { get { return legacyOpcode; } }
		public override string __staticEmitMethod { get { return "EmitOpcode"; } }
	}
}
