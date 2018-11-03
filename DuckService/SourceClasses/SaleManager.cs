using DuckService.DB;
using DuckService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DuckService.SourceClasses
{
    public class SaleManager
    {
        List<Product> order;
        List<Rule> rules;
        public SaleManager(List<Product> _products)
        {
            order = _products;
            rules = DuckShopContext.context.Rules.ToList();

        }
        /// <summary>
        /// Проверка запрещающих правил
        /// </summary>
        /// <returns>true - если все правила выполнены, иначе false</returns>
        public bool CheckRules()
        {
            foreach(var rule in rules.Where(x=>x.Quantity==-1))
            {
                if (!CheckForbidRule(rule))
                    return false;
            }
            return true;
        }

        private bool CheckForbidRule(Rule rule)
        {
            //Счетчик продуктов в заказе, попавших в правило
            int counter = 0;
            foreach (var ruleprod in rule.Products)
            {
                foreach (var prod in order)
                {
                    if(ruleprod.ProductId==prod.ProductId)
                    {
                        counter++;
                        break;
                    }
                }
            }
            if (counter == rule.Products.Count)
                return false;
            else
                return true;
        }
        /// <summary>
        /// Выполнение продажи, изменение количества в БД
        /// </summary>
        /// <returns>текст ошибки. null, если ошибок нет</returns>
        public string Sale()
        {
            using (DbContextTransaction transaction = DuckShopContext.context.Database.BeginTransaction(System.Data.IsolationLevel.Serializable))
            {
                try
                {
                    foreach(var prod in order)
                    {
                        var prodDb = DuckShopContext.context.Products.FirstOrDefault(x => x.ProductId == prod.ProductId);
                        if(prodDb!=null)
                        {
                            if (prodDb.Quantity >= prod.Quantity)
                            {
                                prodDb.Quantity -= prod.Quantity;
                                DuckShopContext.context.SaveChanges();
                            }
                            else
                                throw new Exception("Уточек нет в наличии");
                        }
                    }
                    DuckShopContext.context.SaveChanges();
                    transaction.Commit();
                    return null;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return e.Message;
                }
            }
        }

        /// <summary>
        /// Вычисление стоимости с учетом правил скидок
        /// </summary>
        /// <returns></returns>
        public double CalcCost()
        {
            int discount = 0;
            foreach(var rule in rules.Where(x=>x.Quantity>0))
            {
                int counter = 0;
                foreach(var rulProd in rule.Products)
                {
                    if (order.FirstOrDefault(x => x.ProductId == rulProd.ProductId && x.Quantity >= rule.Quantity) != null)
                        counter++;
                }
                if (counter == rule.Products.Count && discount < rule.Discount)
                    discount = rule.Discount;
            }
            //общая стоимость
            double summ = 0;
            foreach(var prod in order)
            {
                summ += prod.Quantity * prod.Cost;
            }
            return summ -summ*discount/100;
        }
    }
}