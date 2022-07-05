using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.BikeStore.WUI.Models.Database;

namespace Udemy.BikeStore.WUI.Repositories
{
    class CategoryRepository : BaseRepository, IBaseRepository<Category>
    {
        public int DeleteData(Category dataItem)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllData()
        {
            List<Category> dataList = new List<Category>();
            string query = "select * from [DapperLearn].[production].categories";
            dataList = con.Query<Category>(query).ToList();
            return dataList;
        }

        public Category GetById(int id)
        {
            Category data = new Category();
            string query = $"select * from [DapperLearn].[production].categories where category_id= {id}";
            data = con.QueryFirstOrDefault<Category>(query);
            return data;
        }

        public int InsertData(Category dataItem)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(Category dataItem)
        {
            throw new NotImplementedException();
        }
    }
}
