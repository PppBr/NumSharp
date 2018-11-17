﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumSharp.Extensions
{
    public static partial class NumPyExtensions
    {
        public static NDArray<T> delete<T>(this NumPy<T> np, NDArray<T> nd, IEnumerable<T> delete)
        {            
            var nd1 = np.array(nd.Data.Where(x => !delete.Contains(x)));
            nd1.Shape = new Shape(nd1.Data.Length);

            return nd1;
        }
    }
}
