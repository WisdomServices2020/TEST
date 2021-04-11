using Food__Delivery.DAL;
using Food__Delivery.Repository;
using System;
using System.Data.SqlClient;
using System.Linq;
using PagedList;
using System.Web.UI;
using PagedList.Mvc;

namespace Food__Delivery.Models.Home
{


    public class HomeIndexViewModel
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        Food_delEntities context = new Food_delEntities();
        public IPagedList<Tbl_Product> ListOfProducts { get; set; }

        public HomeIndexViewModel CreateModel(string search, int pageSize, int? page)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@search",search??(object)DBNull.Value)
            };
            IPagedList<Tbl_Product> data = context.Database.SqlQuery<Tbl_Product>("GetBySearch @search", param).ToList().ToPagedList(page ?? 1, pageSize);
            
            return new HomeIndexViewModel
            {
                ListOfProducts = data
            };
        }
    }
}
