﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// Intermediate representation of the exclusive-or operation.
	/// </summary>
	public sealed class LogicalXor : ThreeOperandInstruction
	{
		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="LogicalXor"/> class.
		/// </summary>
		public LogicalXor()
		{
		}

		#endregion Construction

		#region ThreeOperandInstruction Overrides

		/// <summary>
		/// Allows visitor based dispatch for this instruction object.
		/// </summary>
		/// <param name="visitor">The visitor object.</param>
		/// <param name="context">The context.</param>
		public override void Visit(IIRVisitor visitor, Context context)
		{
			visitor.LogicalXor(context);
		}

		#endregion ThreeOperandInstruction Overrides
	}
}