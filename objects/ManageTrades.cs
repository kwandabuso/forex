using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forex.objects
{
    class ManageTrades
    {
        private string status;
        private string profit_loss;
        private string amount;
        private string postMotem;

        public ManageTrades(string status, string ProfLoss, string amount, string postM)
        {
            this.status = status;
            profit_loss = ProfLoss;
            this.amount = amount;
            postMotem = postM;
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string ProfitLoss
        {
            get { return profit_loss; }
            set { profit_loss = value; }
        }

        public string Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string PMotem
        {

            get { return postMotem; }
            set { postMotem = value; }
        }
    }
}
