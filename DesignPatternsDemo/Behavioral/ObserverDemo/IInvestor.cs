using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral_DesignPattern.ObserverPattern
{
    /// <summary>

    /// The 'Observer' interface

    /// </summary>

    interface IInvestor
    {
        void Update(Stock stock);
    }
}