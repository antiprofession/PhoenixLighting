using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoenixLighting.Model;

namespace PhoenixLighting.IDAL
{
    public interface IBaseSqlOperation<T> where T:class,new()
    {
        //基本操作
        T AddEntity(T Entity);

        bool Update(T Entity);


        bool InsertEntity(T Entity);

        bool DelEntity(T Entity);


        //查询
        //IQueryable<T> LoadEntities(Func<T, bool> whereLambda);


        //分页
    }

    public interface IProductSqlOperation:IBaseSqlOperation<Product>
    {

    }

    public interface IUserSqlOperation:IBaseSqlOperation<User>
    {

    }
}
