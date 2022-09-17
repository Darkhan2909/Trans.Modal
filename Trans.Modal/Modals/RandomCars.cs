using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trans.Modal.Modals
{
    public class RandomCars : Car
    {
        private List<Trans> cars = new List<Trans>();

        public RandomCars()
        {
        }

        public void AddTrans(Trans transport)
        {
            cars.Add(transport);
        }

        public void PrintInfo()
        {
            foreach (Trans trans in cars)
            {
                trans.TransInfo();
            }
        }

        public override void TransInfo()
        {
            return;
        }
    }
}
