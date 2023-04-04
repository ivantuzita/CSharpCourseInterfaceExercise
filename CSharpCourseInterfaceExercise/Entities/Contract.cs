namespace CSharpCourseInterfaceExercise.Entities {
    public class Contract {

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public void addInstallment(Installment installment) {
            Installments.Add(installment);
        }

        public void removeInstallment(Installment installment) {
            Installments.Remove(installment);
        }

    }
}
