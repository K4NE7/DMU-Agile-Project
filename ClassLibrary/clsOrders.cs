using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public int orderID { get; set; }
        public int customerID { get; set; }
        public DateTime orderDate { get; set; }
        public bool keySent { get; set; }
        public string extraDetails { get; set; }
        public int productID { get; set; }
        public int quantity { get; set; }
    }
}
