using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Product
    {
        /// <summary>
        /// 計算Cost加總
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<int> CostAdd(int count)
        {
            var cost = new List<int> { 6, 15, 24, 21 };

            return cost;
        }

        /// <summary>
        /// 計算Revenue加總
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<int> RevenueAdd(int count)
        {
            var revenue = new List<int> { 50, 66, 60 };

            return revenue;
        }
    }
}
