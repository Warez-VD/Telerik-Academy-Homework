using System.Diagnostics;
using Ninject.Extensions.Interception;
using SchoolSystem.Framework.Core.Contracts;

namespace SchoolSystem.Cli
{
    public class MeasureInterceptor : IInterceptor
    {
        private IWriter writer;

        public MeasureInterceptor(IWriter writer)
        {
            this.writer = writer;
        }

        public void Intercept(IInvocation invocation)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            invocation.Proceed();
            var method = string.Format("Calling method {0} of type {1}...", invocation.Request.Method.Name, invocation.Request.Method.DeclaringType.Name);
            this.writer.WriteLine(method);
            var execution = string.Format("Total execution time for method {0} of type {1} is {2} milliseconds.", invocation.Request.Method.Name, invocation.Request.Method.DeclaringType.Name, stopWatch.ElapsedMilliseconds);
            this.writer.WriteLine(execution);
        }
    }
}
