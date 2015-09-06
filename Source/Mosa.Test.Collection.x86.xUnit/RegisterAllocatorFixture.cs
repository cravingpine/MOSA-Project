﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Xunit;
using Xunit.Extensions;

namespace Mosa.Test.Collection.x86.xUnit
{
	public class RegisterAllocatorFixture : X86TestFixture
	{
		[Fact]
		public void Pressure8()
		{
			Assert.Equal(Mosa.Test.Collection.RegisterAllocatorTests.Pressure8(), Run<int>("Mosa.Test.Collection.RegisterAllocatorTests.Pressure8"));
		}

		[Theory]
		[MemberData("I4MiniI4MiniI4MiniI4MiniI4MiniI4MiniI4Mini", DisableDiscoveryEnumeration = true)]
		public void Pressure7(int a, int b, int c, int d, int e, int f, int g)
		{
			Assert.Equal(Mosa.Test.Collection.RegisterAllocatorTests.Pressure7(a, b, c, d, e, f, g), Run<int>("Mosa.Test.Collection.RegisterAllocatorTests.Pressure7", a, b, c, d, e, f, g));
		}

		[Theory]
		[MemberData("I4MiniI4MiniI4MiniI4MiniI4MiniI4MiniI4Mini", DisableDiscoveryEnumeration = true)]
		public void Pressure9(int a, int b, int c, int d, int e, int f, int g)
		{
			Assert.Equal(Mosa.Test.Collection.RegisterAllocatorTests.Pressure9(a, b, c, d, e, f, g), Run<int>("Mosa.Test.Collection.RegisterAllocatorTests.Pressure9", a, b, c, d, e, f, g));
		}
	}
}
