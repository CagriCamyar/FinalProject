using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success) // this demek bu classın içerisindeki success parametreli ctoru da çalıştır demek
        {
            Message = message; // gether oldugu için set edilemiyor olması lazım ancak getherlar constructor içerisinde set edilebilir!!
          }
        public Result(bool success)
        {
             Success = success;
        }

        public bool Success { get; }

        public string Message {  get; }
    }
}
