using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Item
    {
        #region 物品ID
        /// <summary>
        /// 物品ID
        /// </summary>
        public int ID { get; set; }
        #endregion

        #region 成本
        /// <summary>
        /// 物品成本
        /// </summary>
        public int Cost { get; set; }
        #endregion

        #region 收入
        /// <summary>
        /// 收入
        /// </summary>
        public int Revenue { get; set; }
        #endregion

        #region 售價
        /// <summary>
        /// 物品售價
        /// </summary>
        public int SellPrice { get; set; }
        #endregion
    }
}

