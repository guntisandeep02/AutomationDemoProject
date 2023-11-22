namespace AutomationDemoProject.Util
{
    public class AccountService
    {
            public static ApiResponse CreateAccount(AccountRequest request)
            {
                // Implement account creation logic here
                // For simplicity, generate a static response
                var response = new ApiResponse
                {
                    Data = new Data
                    {
                        NewBalance = request.InitialBalance,
                        AccountName = request.AccountName,
                        AccountNumber = "X123"
                    },
                    Message = "Account X123 created successfully",
                    Errors = new string[] { }
                };

                return response;
            }
        public static ApiResponse Deposit(DepositRequest request)
        {
            // Implement account deposit logic here
            // For simplicity, generate a static response
            var response = new ApiResponse
            {
                Data1 = new DepositData
                {
                    AccountNumber = request.AccountNumber,
                    NewBalance = 2000 // Assuming a fixed new balance for demonstration purposes
                },
                Message = $"${request.Amount} deposited to Account {request.AccountNumber} successfully",
                Errors = new string[] { }
            };

            return response;
        }
        public static ApiResponse Withdraw(WithdrawRequest request)
        {
            // Implement account withdrawal logic here
            // For simplicity, generate a static response
            var response = new ApiResponse
            {
                Data2 = new WithdrawData
                {
                    AccountID = request.AccountNumber,
                    NewBalance = 0 // Assuming a fixed new balance for demonstration purposes
                },
                Message = $"{request.Amount}$ withdrawn from Account {request.AccountNumber} successfully",
                Errors = new string[] { }
            };

            return response;
        }

        public static ApiResponse DeleteAccount(string accountID)
        {
            // Implement account deletion logic here
            // For simplicity, generate a static response
            var response = new ApiResponse
            {
                Data = null,
                Message = $"Account {accountID} deleted successfully",
                Errors = new string[] { }
            };

            return response;
        }
    }
}
