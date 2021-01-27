using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.CsProj;

namespace Stackalloc
{
    internal class MultipleRuntimesConfig : ManualConfig
    {
        public MultipleRuntimesConfig()
        {
            AddJob(Job.Default
                    .WithToolchain(CsProjClassicNetToolchain.Net461)
                    .WithId(".NET 4.6.1"));

            AddJob(Job.Default
                    .WithToolchain(CsProjCoreToolchain.NetCoreApp50)
                    .WithId(".NET 5.0"));
        }
    }
}