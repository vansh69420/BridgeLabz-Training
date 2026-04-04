class LoanUtilityImpl : IApprovable
{
    private string loanType;
    private double interestRate;
    private string loanStatus;

    public void SetLoanDetails(string type)
    {
        loanType = type;

        if (type == "Home") interestRate = 8.5;
        else if (type == "Auto") interestRate = 9.5;
        else interestRate = 11.0;

        loanStatus = "Pending";
    }

    public bool ApproveLoan(Applicant applicant)
    {
        if (applicant.GetCreditScore() >= 650 &&
            applicant.Income >= applicant.LoanAmount / 2)
        {
            loanStatus = "Approved";
            return true;
        }

        loanStatus = "Rejected";
        return false;
    }

    public double CalculateEMI(double principal, double rate, int term)
    {
        double r = rate / 12 / 100;

        if (loanType == "Home") r -= 0.001;
        else if (loanType == "Auto") r += 0.001;

        return principal * r * Math.Pow(1 + r, term) /
               (Math.Pow(1 + r, term) - 1);
    }

    public string GetStatus()
    {
        return loanStatus;
    }

    public double GetRate()
    {
        return interestRate;
    }

    public override string ToString()
    {
        return "Loan Type: " + loanType +
               "\nInterest Rate: " + interestRate +
               "\nLoan Status: " + loanStatus;
    }
}
