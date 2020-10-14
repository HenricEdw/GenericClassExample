using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsShowThisFirst
{
    class GenericClass<T>
    {
        private T m_data;

        public T Data
        {
            get { return m_data; }
            set { m_data = value; }
        }
    }
}
