using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    class Account
    {
        private string number;
        private string name;
        private double balance=0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }

        }

        public double Balance
        {
            get { return balance; }

        }

        public void Deposite(double a)
        {
            balance += a;
            MessageBox.Show(a + " amount is deposited");
        }

        public void Withdraw(double a)
        {
            balance -= a;
            MessageBox.Show(a + " amount is Withdrawn");
        }

        

    }
}
