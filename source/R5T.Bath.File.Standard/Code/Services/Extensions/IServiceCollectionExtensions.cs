using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bath.File.Default;
using R5T.Bath.File.Thessaloniki.Standard;
using R5T.Dacia;


namespace R5T.Bath.File.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a file-based <see cref="IHumanOutput"/> service that uses the default human output file name.
        /// </summary>
        public static IServiceCollection AddFileHumanOutput(this IServiceCollection services,
            IServiceAction<IHumanOutputFileNameProvider> addHumanOutputFileNameProvider)
        {
            services.AddFileHumanOutput(services.AddCDriveHumanOutputFilePathProviderAction(addHumanOutputFileNameProvider));

            return services;
        }

        /// <summary>
        /// Adds a file-based <see cref="IHumanOutput"/> service that uses the default human output file name.
        /// </summary>
        public static IServiceAction<IHumanOutput> AddFileHumanOutputAction(this IServiceCollection services,
            IServiceAction<IHumanOutputFileNameProvider> addHumanOutputFileNameProvider)
        {
            var serviceAction = ServiceAction<IHumanOutput>.New(() => services.AddFileHumanOutput(addHumanOutputFileNameProvider));
            return serviceAction;
        }

        /// <summary>
        /// Adds a file-based <see cref="IHumanOutput"/> service that uses the default human output file name.
        /// </summary>
        public static IServiceCollection AddFileHumanOutput(this IServiceCollection services)
        {
            services.AddFileHumanOutput(services.AddCDriveHumanOutputFilePathProviderAction());

            return services;
        }

        /// <summary>
        /// Adds a file-based <see cref="IHumanOutput"/> service that uses the default human output file name.
        /// </summary>
        public static IServiceAction<IHumanOutput> AddFileHumanOutputAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IHumanOutput>.New(() => services.AddFileHumanOutput());
            return serviceAction;
        }
    }
}