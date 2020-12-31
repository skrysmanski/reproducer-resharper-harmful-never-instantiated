//
// This file contains a reproducer for a ReSharper bug.
//

using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ReSharperReproducer
{
    internal class Reproducer
    {
        public static void Main()
        {
            GetServiceProvider().GetRequiredService<ILogger<Reproducer>>();
        }

        private static IServiceProvider GetServiceProvider()
        {
            return null!;
        }
    }
}
