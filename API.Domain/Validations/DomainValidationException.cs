using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validations
{
    public class DomainValidationException : Exception
    {
        public DomainValidationException(string error) : base(error)
        { }

        public static void When(bool hasError, string msg) 
        {
            if (hasError)
            {
                throw new DomainValidationException(msg);
            }
        }
    }
}
