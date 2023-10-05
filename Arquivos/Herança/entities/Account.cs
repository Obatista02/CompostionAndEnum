﻿using System;
using Course.entities.Exception;

namespace Course.entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double  WithdrawLimit { get; set; }

        public Account() { }

        public Account (int number,string holder, double balance,double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new AccountException("Valor alem do limite");
            }
            else if(amount > Balance)
            {
                throw new AccountException("Valor insuficiente");
            }
            else
            {
                Balance -= amount;
            }
        }
    }
}
