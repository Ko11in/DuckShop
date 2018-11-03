using DuckService.SourceClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DuckService.Models
{
    /// <summary>
    /// Правило
    /// </summary>
    public class Rule
    {
        public int RuleId { get; set; }
        /// <summary>
        /// Минимальное количество для получения скидки. Если Quantity=-1, то правило запрещающее: запрещает заказывать вместе все продукты, которые есть в Products
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Размер скидки в процентах
        /// </summary>
        public int Discount { get; set; }

        /// <summary>
        /// Продукты, на которые действует правило
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }

        public Rule()
        {
            Products = new HashSet<Product>();
        }

    }
}