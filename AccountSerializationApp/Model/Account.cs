using System;
using System.Collections.Generic;
using System.Text;

namespace AccountSerializationApp.Model
{
    class Account
    {
        private int _accountNo;
        private int _balance;
        private readonly string _name;
        public int AccountNO
        {
            set { _accountNo = value; }
            get { return _accountNo; }
        }
        public int Balance
        {
            set { _balance = value; }
            get { return _balance; }
        }
        public void Deposit(int money)
        {
            _balance += money;
        }
    }
}
