using System.Collections.Generic;
using HotChocolate.Resolvers;

namespace HotChocolate.Execution.Instrumentation
{
    internal sealed class NoopDiagnosticEvents
        : IDiagnosticEvents
        , IActivityScope
    {
        public IActivityScope ParseDocument(
            IRequestContext context) => this;

        public void SyntaxError(
            IRequestContext context,
            IError error)
        { }

        public IActivityScope ValidateDocument(
            IRequestContext context) => this;

        public void ValidationErrors(
            IRequestContext context,
            IReadOnlyList<IError> errors)
        { }

        public IActivityScope ResolveFieldValue(
            IMiddlewareContext context) => this;

        public void ResolverError(
            IMiddlewareContext context,
            IError error)
        { }

        public void AddedDocumentToCache(
            IRequestContext context)
        { }

        public void RetrievedDocumentFromCache(
            IRequestContext context)
        { }

        public void BatchDispatched(IRequestContext context)
        { }

        public void ExecutorCreated(string name, IRequestExecutor executor)
        { }

        public void ExecutorEvicted(string name, IRequestExecutor executor)
        { }

        public void Dispose() { }
    }
}
