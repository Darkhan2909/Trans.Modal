using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trans.Modal.Modals
{
    public abstract class Trans
    {
        private int v1;
        private int v2;

        public Trans() : this(0, 0)
        {

        }

        protected Trans(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public string TransName { get; set; }
        public string TransModel { get; set; }

        public int TransId { get; set; }

        public DateTime CreateTransDate { get; set; }
        public int TransWeight { get; set; }

        public int MaxWeight { get; set; }

        public int MinWeight { get; set; }

        public void WeigthInfo(int MaxWeight,int MinWeight)
        {
            this.MaxWeight = MaxWeight;
            this.MinWeight = MinWeight;
        }
        public abstract void TransInfo();

        public virtual double WeigthInfo()
        {
            //Console.WriteLine(TransWeight);
            return MaxWeight / TransWeight;
        }
    }
}
