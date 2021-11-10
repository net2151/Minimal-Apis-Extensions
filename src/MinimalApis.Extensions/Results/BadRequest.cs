﻿using MinimalApis.Extensions.Metadata;

namespace MinimalApis.Extensions.Results;

/// <summary>
/// Represents an <see cref="IResult"/> for a <see cref="StatusCodes.Status400BadRequest"/> or other 4xx response.
/// </summary>
public class BadRequest : StatusCode, IProvideEndpointResponseMetadata
{
    private const int ResponseStatusCode = StatusCodes.Status400BadRequest;

    /// <summary>
    /// Initializes a new instance of the <see cref="BadRequest"/> class.
    /// </summary>
    /// <param name="message">An optional message to return in the response body.</param>
    /// <param name="statusCode">The status code to return. Defaults to <see cref="StatusCodes.Status400BadRequest"/>.</param>
    public BadRequest(string? message = null, int statusCode = ResponseStatusCode)
        : base(statusCode, message)
    {

    }

    /// <summary>
    /// Provides metadata for parameters to <see cref="Endpoint"/> route handler delegates.
    /// </summary>
    /// <param name="parameter">The parameter to provide metadata for.</param>
    /// <param name="services">The <see cref="IServiceProvider"/>.</param>
    /// <returns>The metadata.</returns>
    public static IEnumerable<object> GetMetadata(Endpoint endpoint, IServiceProvider services)
    {
        yield return new Mvc.ProducesResponseTypeAttribute(ResponseStatusCode);
    }
}
