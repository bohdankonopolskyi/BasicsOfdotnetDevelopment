using System;
using System.Reflection;
using System.Runtime.ExceptionServices;

namespace ORPZ_Lab3_CreationalPatterns
{
    public static class GenericEncryptorFactory<IEncryptor, T> where T : IEncryptor, new()
    {
        public static T Create()
        {
            try
            {

                return new T();
            }
            catch (TargetInvocationException e)
            {
                var edi = ExceptionDispatchInfo.Capture(e.InnerException);
                edi.Throw();
                return default;
            }
        }
    }
}
