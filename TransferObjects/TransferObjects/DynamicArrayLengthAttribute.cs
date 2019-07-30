using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.AppGameServer.TransferObjects
{
    public class DynamicArrayLengthAttribute : Attribute
    {
        private string FFieldName = string.Empty;

        public DynamicArrayLengthAttribute(string szFieldName)
        {
            FFieldName = szFieldName;
        }
    }
}
