using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AutomationDemoProject.Util
{
    public class ApiResponse
    {
        public Data Data { get; set; }
        public string Message { get; set; }
        public string[] Errors { get; set; }

        public DepositData Data1 { get; set; }
        public WithdrawData Data2 { get; set; } 
        public object Data3 { get; set; } // Use 'object' type to handle different data structures


    }
    public class DepositData
    {
        public string AccountNumber { get; set; }
        public decimal NewBalance { get; set; }
    }
    public class WithdrawData
    {
        public string AccountID { get; set; }
        public decimal NewBalance { get; set; }
    }
}
