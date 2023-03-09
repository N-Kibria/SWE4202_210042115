using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08
{
    internal class product
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int qty { get; set; }

        public int min_qty { get; set; }
        public int req_amount { get; set;}

        public product(int id, string name, double price, int qty, int min_qty, int req_amount)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.min_qty = min_qty;
            this.req_amount = req_amount;
        }
        public void auto_req()
        {
            qty += req_amount;

        }
        public void req(int amount)
        {
            qty += amount;
        }

    }
}
