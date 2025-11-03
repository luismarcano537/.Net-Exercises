using System;
using ContractSystem.Entities;

namespace ContractSystem.Services
{
    internal class ContractService
    {
        public IOnlinePaymentService _onlinePaymentService { get; set; }

        public ContractService(IOnlinePaymentService onlinepaymentService)
        {
            _onlinePaymentService = onlinepaymentService;
        }
        public void processContract(Contract contract, int months)
        {
            double amount = contract.totalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double updateAmount = amount + _onlinePaymentService.Interest(amount, i);
                double fullAmount = updateAmount + _onlinePaymentService.PaymentFee(updateAmount);
                contract.AddInstallment(new Installment(dueDate, fullAmount));
            }
        }
    }
}
