using HotChocolate.Execution;
using HotChocolate.Execution.Instrumentation;
using Microsoft.Extensions.DiagnosticAdapter;

namespace Api
{
    public class DiagnosticObserver : IDiagnosticObserver
    {
        [DiagnosticName("HotChocolate.Execution.Query.Start")]
        public void BeginQueryExecute(IQueryContext context)
        {
            // doesn't trigger
        }
    }
}
