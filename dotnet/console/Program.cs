using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace com.opusmagus
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = AppConfig.BuildServiceProvider();
            var logger = serviceProvider.GetService<ILogger>();
            var processOrderCommand = serviceProvider.GetService<ProcessOrderCommand>();
            logger.LogInformation( "Template Method Pattern - Started..." );
            processOrderCommand.Execute(new ProcessOrderInputModel());
            logger.LogInformation( "Template Method Pattern - Ended!" );
        }
    }
}