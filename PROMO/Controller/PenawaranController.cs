using PROMO.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROMO.Controller
{
    class PenawaranController
    {
        private List<Item> items;

        public PenawaranController()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            this.items.Add(item);
        }

        public List<Item> getItems()
        {
            return this.items;
        }

        internal void addItem(Item drink1)
        {
            throw new NotImplementedException();
        }
    }
}
