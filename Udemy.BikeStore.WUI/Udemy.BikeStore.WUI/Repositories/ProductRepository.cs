using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.BikeStore.WUI.Models.StoreProcedure;
using Udemy.BikeStore.WUI.Models.ViewModel;

namespace Udemy.BikeStore.WUI.Repositories
{
    public class ProductRepository : BaseRepository, IBaseRepository<UpdateProductSP>
    {
        public int DeleteData(UpdateProductSP dataItem)
        {
            var Params = new { id = dataItem.product_id };
           return con.Execute("DeleteProductById", Params, commandType: System.Data.CommandType.StoredProcedure);
        }

        public List<UpdateProductSP> GetAllData()
        {
            throw new NotImplementedException();
        }

        public List<ProdcutListViewModel> GetAllData2()
        {

            List<ProdcutListViewModel> dataItemList = new List<ProdcutListViewModel>();
            string query = @"select P.product_id, B.brand_name, C.category_name, P.product_name, P.model_year, p.list_price
              from production.products P 
             inner join production.brands B on P.brand_id = B.brand_id
             inner join production.categories C on P.category_id = C.category_id";
            dataItemList = con.Query<ProdcutListViewModel>(query).ToList();

            return dataItemList;
        }

        public UpdateProductSP GetById(int id)
        {
            UpdateProductSP dataItem = null;
            string query = $"select * from production.products where product_id ={id}";
            dataItem = con.QueryFirstOrDefault<UpdateProductSP>(query);
            return dataItem;
        }

        public int InsertData(UpdateProductSP dataItem)
        {
            var Params = new {
                product_name = dataItem.product_name,
                brand_id = dataItem.brand_id,
                category_id = dataItem.category_id,
                model_year = dataItem.model_year,

            };
            return con.Execute("InsertProduct", Params, commandType: System.Data.CommandType.StoredProcedure);
             
        }

        public int UpdateData(UpdateProductSP dataItem)
        {
           return con.Execute("updateProduct", dataItem, commandType: System.Data.CommandType.StoredProcedure);
        }








    }
}
