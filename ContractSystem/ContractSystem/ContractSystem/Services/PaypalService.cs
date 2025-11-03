using System;
using ContractSystem.Entities;

namespace ContractSystem.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentagem = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentagem;
        }
    }
}
