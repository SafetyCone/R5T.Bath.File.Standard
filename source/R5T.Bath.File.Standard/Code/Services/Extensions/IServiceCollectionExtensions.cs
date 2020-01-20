using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bath.File.Default;
using R5T.Bath.File.Thessaloniki.Standard;
using R5T.Lombardy;


namespace R5T.Bath.File.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddFileHumanOutput<THumanOutputFileNameProvider, TStringlyTypedPathOperator>(this IServiceCollection services)
            where THumanOutputFileNameProvider: class, IHumanOutputFileNameProvider
            where TStringlyTypedPathOperator: class, IStringlyTypedPathOperator
        {
            services.AddHumanOutputFilePathProvider_TemporaryDirectoryBased<THumanOutputFileNameProvider, TStringlyTypedPathOperator>();

            return services;
        }

        public static IServiceCollection AddFileHumanOutput<THumanOutputFileNameProvider>(this IServiceCollection services)
            where THumanOutputFileNameProvider : class, IHumanOutputFileNameProvider
        {
            services.AddFileHumanOutput<THumanOutputFileNameProvider, StringlyTypedPathOperator>();

            return services;
        }

        /// <summary>
        /// Uses the <see cref="DefaultHumanOutputFileNameProvider"/> service.
        /// </summary>
        public static IServiceCollection AddFileHumanOutput(this IServiceCollection services)
        {
            services.AddHumanOutputFilePathProvider_TemporaryDirectoryBased<StringlyTypedPathOperator>();

            return services;
        }
    }
}
