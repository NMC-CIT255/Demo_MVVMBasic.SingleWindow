using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_MVVMBasic;

namespace Demo_MVVMBasic.Models
{
    public class Widget : ObservableObject
    {
        private int _currentInventory;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Color { get; set; }
        public double UnitPrice { get; set; }

        public int CurrentInventory
        {
            get { return _currentInventory; }
            set 
            {
                _currentInventory = value;
                OnPropertyChanged(nameof(CurrentInventory));
            }
        }

        /// <summary>
        /// makes a Shallow Copy of the Widget object
        /// </summary>
        /// <returns>Shallow Copy of the Widget object</returns>
        public Widget Copy()
        {
            return (Widget)this.MemberwiseClone();
        }
    }
}
