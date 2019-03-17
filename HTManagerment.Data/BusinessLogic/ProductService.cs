using System;
using System.Collections.Generic;
using System.Linq;
using HTManagerment.Data.Model;

namespace HTManagerment.Data.BusinessLogic
{
    public static class ProductService
    {
        public static readonly QuanLyCanContext Context = new QuanLyCanContext();

        public static List<ProductModel> GetProduct()
        {
            return Context.Products.ToList();
        }

        public static ProductModel GetById(int id)
        {
            return Context.Products.Find(id);
        }

        public static bool DeleteProduct(int id)
        {
            var item = Context.Products.Find(id);
            if (item == null)
            {
                return false;
            }

            Context.Products.Remove(item);
            return true;
        }

        public static bool UpdateProduct(ProductModel model)
        {
            if (model == null) return false;
            if (model.ProductId == 0)
            {
                var item = new ProductModel
                {
                    ProductName = model.ProductName,
                    Unit = model.Unit,
                    Quantity = model.Quantity,
                    Price = model.Price,
                    DateCreated = DateTime.Now,
                    Version = 1
                };
                Context.Products.Add(item);
                Context.SaveChanges();
                return true;
            }
            var currentUnit = Context.Products.Find(model.ProductId);
            if (currentUnit == null) return false;
            currentUnit.ProductName = model.ProductName;
            currentUnit.Price = model.Price;
            currentUnit.Unit = model.Unit;
            currentUnit.Quantity = model.Quantity;
            currentUnit.DateModified = DateTime.Now;
            currentUnit.Version = ++currentUnit.Version;
            Context.SaveChanges();
            return true;
        }
    }
}