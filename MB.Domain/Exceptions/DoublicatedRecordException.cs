using System;

namespace MB.Domain.Exceptions
{
    public  class DoublicatedRecordException:Exception
    {
        public DoublicatedRecordException()
        {
                
        }

        public DoublicatedRecordException(string message):base(message)
        {

        }
    }
}
