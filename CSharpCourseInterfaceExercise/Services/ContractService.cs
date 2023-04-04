using CSharpCourseInterfaceExercise.Entities;

namespace CSharpCourseInterfaceExercise.Services {
    class ContractService {

        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService) {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months) {
            double vpm = contract.TotalValue / months;
            for (int i = 1; i <= months; i++) {
                DateTime dueDate = contract.Date.AddMonths(i);
                double total = _onlinePaymentService.PaymentFee(_onlinePaymentService.Interest(vpm, i));
                contract.addInstallment(new Installment(dueDate, total));
            }
        }
    }
}
