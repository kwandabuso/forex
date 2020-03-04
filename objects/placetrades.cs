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

        public placetrades(string decision, string notes)
        {
            this.decision = decision;
            this.notes = notes;
        }



        public string makedecision
        {
            //get{
            //    return decision; } 
        set { decision = value; }
        }
        public string myNotes
        {
            //get
            //{
            //    return notes;
            //}
            set { notes = value; }
        }
    }
}
