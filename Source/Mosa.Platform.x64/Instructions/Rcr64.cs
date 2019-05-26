// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x64.Instructions
{
	/// <summary>
	/// Rcr64
	/// </summary>
	/// <seealso cref="Mosa.Platform.x64.X64Instruction" />
	public sealed class Rcr64 : X64Instruction
	{
		public override int ID { get { return 513; } }

		internal Rcr64()
			: base(1, 2)
		{
		}

		public override bool ThreeTwoAddressConversion { get { return true; } }

		public override bool IsZeroFlagModified { get { return true; } }

		public override bool IsCarryFlagModified { get { return true; } }

		public override bool IsOverflowFlagModified { get { return true; } }

		public override void Emit(InstructionNode node, BaseCodeEmitter emitter)
		{
			System.Diagnostics.Debug.Assert(node.ResultCount == 1);
			System.Diagnostics.Debug.Assert(node.OperandCount == 2);
			System.Diagnostics.Debug.Assert(node.Result.IsCPURegister);
			System.Diagnostics.Debug.Assert(node.Operand1.IsCPURegister);
			System.Diagnostics.Debug.Assert(node.Result.Register == node.Operand1.Register);

			if (node.Operand2.IsCPURegister)
			{
				emitter.OpcodeEncoder.SuppressByte(0x40);
				emitter.OpcodeEncoder.AppendNibble(0b0100);
				emitter.OpcodeEncoder.AppendBit(0b1);
				emitter.OpcodeEncoder.AppendBit(0b0);
				emitter.OpcodeEncoder.AppendBit(0b0);
				emitter.OpcodeEncoder.AppendBit((node.Result.Register.RegisterCode >> 3) & 0x1);
				emitter.OpcodeEncoder.AppendByte(0xD3);
				emitter.OpcodeEncoder.Append2Bits(0b11);
				emitter.OpcodeEncoder.Append3Bits(0b011);
				emitter.OpcodeEncoder.Append3Bits(node.Result.Register.RegisterCode);
				return;
			}

			if (node.Operand2.IsConstantOne)
			{
				emitter.OpcodeEncoder.SuppressByte(0x40);
				emitter.OpcodeEncoder.AppendNibble(0b0100);
				emitter.OpcodeEncoder.AppendBit(0b1);
				emitter.OpcodeEncoder.AppendBit(0b0);
				emitter.OpcodeEncoder.AppendBit(0b0);
				emitter.OpcodeEncoder.AppendBit((node.Result.Register.RegisterCode >> 3) & 0x1);
				emitter.OpcodeEncoder.AppendByte(0xD1);
				emitter.OpcodeEncoder.Append2Bits(0b11);
				emitter.OpcodeEncoder.Append3Bits(0b011);
				emitter.OpcodeEncoder.Append3Bits(node.Result.Register.RegisterCode);
				return;
			}

			if (node.Operand2.IsConstant)
			{
				emitter.OpcodeEncoder.SuppressByte(0x40);
				emitter.OpcodeEncoder.AppendNibble(0b0100);
				emitter.OpcodeEncoder.AppendBit(0b1);
				emitter.OpcodeEncoder.AppendBit(0b0);
				emitter.OpcodeEncoder.AppendBit(0b0);
				emitter.OpcodeEncoder.AppendBit((node.Result.Register.RegisterCode >> 3) & 0x1);
				emitter.OpcodeEncoder.AppendByte(0xC1);
				emitter.OpcodeEncoder.Append2Bits(0b11);
				emitter.OpcodeEncoder.Append3Bits(0b011);
				emitter.OpcodeEncoder.Append3Bits(node.Result.Register.RegisterCode);
				emitter.OpcodeEncoder.Append8BitImmediate(node.Operand2);
				return;
			}

			throw new Compiler.Common.Exceptions.CompilerException("Invalid Opcode");
		}
	}
}
