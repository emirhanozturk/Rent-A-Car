using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }
        //invocation eklemek istediğimiz metod olarak düşünebiliriz.
        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
