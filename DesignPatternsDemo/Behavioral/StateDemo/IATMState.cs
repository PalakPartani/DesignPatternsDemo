using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourStateDemo
{
    public interface IATMState
    {
        void InsertDebitCard();
        void EjectDebitCard();
        void EnterPin();
        void WithdrawMoney();
    }
}
