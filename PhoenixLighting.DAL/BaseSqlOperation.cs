using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixLighting.DAL
{
    public class BaseSqlOperation<T> where T:class
    {
        //基本操作
        public T AddEntity(T Entity)
        {
            return Entity;
        }

        public bool Update(T Entity)
        {
            return true || false;
        }

        public bool InsertEntity(T Entity)
        {
            return true || false;
        }

        public bool DelEntity(T Entity)
        {
            return true || false;
        }

        //查询

        //分页

    }
}
