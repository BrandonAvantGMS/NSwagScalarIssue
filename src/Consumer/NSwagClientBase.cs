using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Consumer
{
    /// <summary>
    /// Base class for NSwag-generated OpenAPI/Swagger Specification API clients.
    /// </summary>
    public abstract class NSwagClientBase
    {      
        /// <summary>
        /// Invoked by NSwag-generated OpenAPI/Swagger Specification API clients Classes to add custom attributes to <see cref="HttpRequestMessage"/>.
        /// </summary>
        /// <param name="cancellationToken">Token with which the pending operation is cancelled.</param>
        /// <returns>A <see cref="HttpRequestMessage"/> object with customized attributed to be used in auto-generated OpenAPI/Swagger 
        /// Specification API descendant API client classes.</returns>
        protected Task<HttpRequestMessage> CreateHttpRequestMessageAsync(CancellationToken cancellationToken)
        {
            var httpRequestMessage = new HttpRequestMessage();

            return Task.FromResult(httpRequestMessage);
        }
    }
}