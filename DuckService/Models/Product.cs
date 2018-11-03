using DuckService.SourceClasses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DuckService.Models
{
    /// <summary>
    /// Описание продукта
    /// </summary>
    public class Product
    {
        public int ProductId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Цена за единицу
        /// </summary>
        public double Cost { get; set; }
        /// <summary>
        /// Цвет
        /// </summary>
        public DuckColors Color { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Rule> Rules { get; set; }
        
        public Product()
        {
            Rules = new HashSet<Rule>();
        }
        public Product(string _name, int _quantity, DuckColors _color, double _cost)
        {
            Name = _name;
            Quantity = _quantity;
            Color = _color;
            Cost = _cost;
        }
    }
}