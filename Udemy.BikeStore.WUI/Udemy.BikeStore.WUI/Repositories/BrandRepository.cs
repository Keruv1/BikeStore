using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.BikeStore.WUI.Models.Database;

namespace Udemy.BikeStore.WUI.Repositories
{
    public class BrandRepository : BaseRepository, IBaseRepository<Brand>
    {
        public int DeleteData(Brand dataItem)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAllData()
        {
            List<Brand> dataItemList = new List<Brand>();
            string query = "select * from [DapperLearn].[production].[brands]";
            dataItemList = con.Query<Brand>(query).ToList();
            return dataItemList;
        }

        public Brand GetById(int id)
        {
            Brand dataItem = new Brand();
            string query = $"select * from [DapperLearn].[production].[brands] where brand_id = {id}";
            dataItem = con.QueryFirstOrDefault<Brand>(query);
            return dataItem;
            
        }

        public int InsertData(Brand dataItem)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(Brand dataItem)
        {
            throw new NotImplementedException();
        }
    }
}
