using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Shared.RequestFeatures
{
    public abstract class RequestParameter
    {
        const int MaxPageSize = 20;
        public int PageNumber { get; set; } = 1;
        private int pageSize=10;

        public int PageSize
        {
            get { return pageSize; }
            set { 
                pageSize = (value>MaxPageSize)? MaxPageSize:value; 
            
                }
        }
        //public string? OrderBy { get; set; }

    }
}
