﻿using System.Threading;
using ImplicitNullability.Plugin.Tests;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: Apartment(ApartmentState.STA)]

namespace ImplicitNullability.Plugin.Tests
{
    [ZoneDefinition]
    public interface IImplicitNullabilityTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<IImplicitNullabilityZone>
    {
    }

    [ZoneMarker]
    public class ZoneMarker : IRequire<IImplicitNullabilityTestEnvironmentZone>
    {
    }
}

// Note: Global namespace to workaround (or hide) https://youtrack.jetbrains.com/issue/RSRP-464493.
[SetUpFixture]
public class TestEnvironmentSetUpFixture : ExtensionTestEnvironmentAssembly<IImplicitNullabilityTestEnvironmentZone>
{
}
