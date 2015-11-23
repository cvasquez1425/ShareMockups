using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareMockups.DomainClasses
{
    public class TrainingProductViewModel
    {
        public TrainingProductViewModel()
        {
            Products = new List<TrainingProduct>();  // initialize our Products object
        }

        //HOLD entity Class TrainingProduct data.
        public List<TrainingProduct> Products { get; set; }

        public void Get()
        {
            TrainingProductManager mgr = new TrainingProductManager();

            Products = mgr.Get();
        }
    }
}
