using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPrivilegeCopy.Model
{
    public class ControlDataSourceModel
    {
        public List<ControlDataItemModel> ControlDataItemModel { get; set; }
    }

    public class ControlDataItemModel
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string LogicalName { get; set; }
    }
}
