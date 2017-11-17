using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects; 

namespace AOPDemo.Aspects
{
    [Serializable]
    public class ConsoleLoggingAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("{0}.{1} OnEntry",
                              args.Method.DeclaringType.Name,
                              args.Method.Name);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            Console.WriteLine("{0}.{1} OnSuccess",
                              args.Method.DeclaringType.Name,
                              args.Method.Name);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("{0}.{1} OnExit",
                              args.Method.DeclaringType.Name,
                              args.Method.Name);
        }

       
    }
}
