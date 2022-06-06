using System.Collections.Generic;
using System.Linq;

namespace Singleton
{
    sealed class BusinessErrorHandler
    {
        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        private static readonly BusinessErrorHandler instance = new BusinessErrorHandler();

        private readonly List<BusinessError> errors;


        // Note: constructor is 'private'
        private BusinessErrorHandler()
        {
            // Load list of error from "DB", so we would load this data only once.
            errors = new List<BusinessError>
                {
                  new BusinessError{ Id = 1001, Message = "This patient already exist." },
                  new BusinessError{ Id = 1002, Message = "This doctor already exist." },
                  new BusinessError{ Id = 1003, Message = "This patient already is active in another vendor." },
                  new BusinessError{ Id = 1004, Message = "This patient has pending appointments." },
                  new BusinessError{ Id = 1005, Message = "This patient .has pending bills." },
                };
        }

        public static BusinessErrorHandler GetInstance()
        {
            return instance;
        }

        public BusinessError GetErrorMessage(int errorId)
        {
            return errors.FirstOrDefault(error => error.Id.Equals(errorId));
        }


        //public static LoadBalancer GetLoadBalancer()
        //{
        //    // Support multithreaded applications through
        //    // 'Double checked locking' pattern which (once
        //    // the instance exists) avoids locking each
        //    // time the method is invoked
        //    if (instance == null)
        //    {
        //        lock (locker)
        //        {
        //            if (instance == null)
        //            {
        //                instance = new LoadBalancer();
        //            }
        //        }
        //    }
        //    return instance;
        //}
    }
}
