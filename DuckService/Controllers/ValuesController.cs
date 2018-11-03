using DuckService.DB;
using DuckService.Models;
using DuckService.SourceClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DuckService.Controllers
{
    public class DuckShopController : ApiController
    {
        // GET api/DuckShop
        //Возвращает список доступных продуктов
        public IEnumerable<Product> Get()
        {
            try
            {
                return DB.DuckShopContext.context.Products.ToList();
            }
            catch
            {
                return null;
            }
        }

        // POST api/DuckShop
        // Формирует заказ на основе запроса
        public IHttpActionResult Post([FromBody]List<Product> order)
        {
            if(order.Count==0)
                return BadRequest("Пустой заказ");
            SaleManager SM = new SaleManager(order);
            bool isRulesOk = SM.CheckRules();
            if (isRulesOk)
            {
                string error = SM.Sale();
                if (error != null)
                    return BadRequest(error);
                double cost = SM.CalcCost();
                return Ok(cost);
            }
            else
                return BadRequest("Не выполнены требования заказа");
        }

        // PUT api/DuckShop
        // Устанавливает количество товара в БД
        [AcceptVerbs("PUT")]
        public IHttpActionResult Put([FromBody]List<Product> products)
        {
            try
            {
                foreach(var prod in products)
                {
                    var dbprod=DB.DuckShopContext.context.Products.FirstOrDefault(x => x.ProductId == prod.ProductId);
                    if(dbprod!=null)
                    {
                        dbprod.Quantity = prod.Quantity;
                    }
                }
                DB.DuckShopContext.context.SaveChanges();
                return Ok("Обновление выполнено");
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
