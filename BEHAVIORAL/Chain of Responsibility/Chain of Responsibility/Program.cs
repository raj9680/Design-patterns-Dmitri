using System;

/* Chain of Responsibility: It is a behavioral design pattern
 * The main intent of this pattern is to avoid coupling between the sender of a request from its receiver by giving more than one object a chance to handle the request. 
 */

namespace Chain_of_Responsibility
{
    internal class ExpenseReport
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public ExpenseReport(string Name, int Amount)
        {
            this.Name = Name;
            this.Amount = Amount;
        }
    }

    internal interface IManager
    {
        void SetSupervisor(IManager manager);
        void ApproveRequest(ExpenseReport expenseReport);
    }


    /* Level 1
     */
    internal class SeniorManager : IManager
    {
        private IManager manager;

        /* Self Approve
         */
        public void ApproveRequest(ExpenseReport expenseReport)
        {
            if (expenseReport.Amount < 500) Console.WriteLine("Approved by Manager");
            else manager?.ApproveRequest(expenseReport);
        }

        /* Approve by Manager
         */
        public void SetSupervisor(IManager manager)
        {
            this.manager = manager;
        }
    }


    /* Level 2
     */
    internal class VicePresident : IManager
    {
        private IManager manager;

        /* Self Approve
         */
        public void ApproveRequest(ExpenseReport expenseReport)
        {
            if (expenseReport.Amount < 1000) Console.WriteLine("Approved by VP");
            else manager?.ApproveRequest(expenseReport);
        }

        /* Approve by Manager
         */
        public void SetSupervisor(IManager manager)
        {
            this.manager = manager;
        }
    }

    /* Level 3
     */
    internal class COO : IManager
    {
        private IManager manager;

        /* Self Approve
         */
        public void ApproveRequest(ExpenseReport expenseReport)
        {
            if (expenseReport.Amount < 5000) Console.WriteLine("Approved by COO");
            else Console.WriteLine("Not Approved!");
        }

        /* Approve by Manager
         */
        public void SetSupervisor(IManager manager)
        {
            this.manager = manager;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var manager = new SeniorManager();
            var vp = new VicePresident();
            var coo = new COO();

            manager.SetSupervisor(vp);
            vp.SetSupervisor(coo);


            var expense = new ExpenseReport("Monitor", 100);
            Console.WriteLine($"Expense Report Name: {expense.Name}, Amount: {expense.Amount}");
            manager.ApproveRequest(expense);    Console.WriteLine("-------------------------------------");


            var expense1 = new ExpenseReport("Desk", 900);
            Console.WriteLine($"Expense Report Name: {expense1.Name}, Amount: {expense1.Amount}");
            manager.ApproveRequest(expense1);   Console.WriteLine("-------------------------------------");


            var expense2 = new ExpenseReport("Travel", 5500);
            Console.WriteLine($"Expense Report Name: {expense2.Name}, Amount: {expense2.Amount}");
            manager.ApproveRequest(expense2);
        }
    }
}
