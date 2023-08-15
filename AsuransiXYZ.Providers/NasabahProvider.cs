using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsuransiXYZ.Provider
{
    public class NasabahProvider
    {
        private static NasabahProvider _instance = new NasabahProvider();
        public static NasabahProvider GetProvider()
        {
            return _instance;
        }
    }
}
