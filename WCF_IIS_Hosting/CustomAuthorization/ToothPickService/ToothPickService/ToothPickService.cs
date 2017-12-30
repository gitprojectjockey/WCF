using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace ToothPickService
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    
    public class ToothPickService : IToothPickService
    {
       [WebGet(UriTemplate = "Toothpicks")]
        public IEnumerable<ToothPick> GetToothPickList()
        {
            return ToothPickList();
        }

        IEnumerable<ToothPick> ToothPickList()
        {
            List<ToothPick> tpBoxes = new List<ToothPick>()
            {
               new ToothPick{ProductCode = "1112",Length=2, Flavor="Cinnamon", Name="Cinn2", BoxCount=500,BoxCost=2.30M},
               new ToothPick{ProductCode = "1122",Length=2, Flavor="Plain", Name="Pl2", BoxCount=500,BoxCost=1.30M},
               new ToothPick{ProductCode = "1132",Length=3, Flavor="Chocolate", Name="Ch3", BoxCount=500,BoxCost=3.40M},
               new ToothPick{ProductCode = "1142",Length=3, Flavor="Bacon", Name="Bac3", BoxCount=1500,BoxCost=4.44M},
               new ToothPick{ProductCode = "1152",Length=2, Flavor="BlueBerry", Name="Blu2", BoxCount=500,BoxCost=2.30M}
            };
            return tpBoxes;
        }
    }
}
