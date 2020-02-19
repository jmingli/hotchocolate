using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Patterns;

namespace HotChocolate.AspNetCore
{
    public static class HttpGetEndpointRouteBuilderExtensions
    {
        public static IEndpointConventionBuilder MapGraphQLHttpGet(
            this IEndpointRouteBuilder endpointRouteBuilder,
            RoutePattern pattern)
        {
            if (endpointRouteBuilder == null)
            {
                throw new ArgumentNullException(nameof(endpointRouteBuilder));
            }

            RequestDelegate pipeline = endpointRouteBuilder.CreateApplicationBuilder()
                .UseMiddleware<HttpGetMiddleware>()
                .Build();

            return endpointRouteBuilder.Map(pattern, pipeline);
        }
    }
}
