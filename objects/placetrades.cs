using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forex.objects
{
   public class placetrades
    {
        private string decision;
        private string notes;
        private string place;

        public placetrades(string decision, string placetrades,string notes)
        {
            this.decision = decision;
            place = placetrades;
            this.notes = notes;
        }

        public string makedecision
        {
            get
            {
                return decision;
            }
            set { decision = value; }
        }

        public string indecies
        {
            get
            {
                return place;
            }
            set { place = value; }
        }

        public string myNotes
        {
            get
            {
                return notes;
            }
            set { notes = value; }
        }
    }
}
