using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNow.Models
{
    public class BlockchainChart
    {
        [Display(Description = "Status", AutoGenerateField = false)]
        public string Status { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Period { get; set; }
        public string Description { get; set; }
        public List<BlockchainChartValue> Values { get; set; }
    }
    public class BlockchainChartValue
    {
        public DateTime X { get; set; }
        public decimal Y { get; set; }
    }

}
