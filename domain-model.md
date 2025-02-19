# Domain model

## Bank Challenge

## User Stories

### Core 

As a customer,
So I can safely store/use my money,
I want to create a current account.

As a customer,
So I can save for a rainy day,
I want to create a savings account.

As a customer,
So I can keep a record of my finances,
I want to generate bank statements with transaction dates, amounts, and balance at the time of transaction.

As a customer,
So I can use my account,
I want to deposit and withdraw funds.

### Extension 

As an engineer,
So I don't need to keep track of state,
I want account balances to be calculated based on transaction history instead of stored in memory.

As a bank manager,
So I can expand,
I want accounts to be associated with specific branches.

As a customer,
So I have an emergency fund,
I want to be able to request an overdraft on my account.

As a bank manager,
So I can safeguard our funds,
I want to approve or reject overdraft requests.

As a customer,
So I can stay up to date,
I want statements to be sent as messages to my phone.


## Domain Model 


| Class                    | Methods/properties                                                | Scenario                                       | Outputs          |
|--------------------------|-------------------------------------------------------------------|------------------------------------------------|------------------|
| Account                  | Deposit(decimal amount)                                           | store money in account                         |                  |
| Account                  | Withdraw(decimal amount)                                          | withdraw money from account                    |                  |
| Account                  | List<Transaction> TransactionHistory                              | store transaction history                      |                  |
| Account                  | AddTransaction(Transaction t)                                     | add a transaction to history                   |                  |
| Account                  | GenerateBankStatement()                                           | generate bank statement                        | string           |
| Account                  | CalculateBalance()                                                | calculate balance based on transaction history | decimal          |
| Account                  | Branch branch                                                     | account associated with a specific branch      |                  |
| Customer                 | RequestOverdraft(CurrentAccount account, decimal amount)          | request overdraft                              | OverdraftRequest |
| Customer                 | List<Account> accounts                                            | hold all accounts                              |                  |
| CurrentAccount : Account | OverdraftLimit                                                    | limit for overdraft                            |                  |
| SavingAccount : Account  |                                                                   |                                                |                  |
| BankManager              | HandleOverdraftRequest(OverdraftRequest request, bool isApproved) | approve or reject an overdraft request         |                  |
| OverdraftRequest         | Account, RequestedAmount, RequestStatus                           |                                                |                  |
| Transaction              | Date, Amount, Credit/debit                                        |                                                |                  |