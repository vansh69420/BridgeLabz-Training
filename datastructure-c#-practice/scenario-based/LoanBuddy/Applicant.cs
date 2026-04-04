public class Applicant
{
    public string Name;
    public double Income;
    public double LoanAmount;

    private int creditScore;

    public void SetData(string name, int score, double income, double loanAmount)
    {
        Name = name;
        creditScore = score;
        Income = income;
        LoanAmount = loanAmount;
    }

    public int GetCreditScore()
    {
        return creditScore;
    }

    public override string ToString()
    {
        return "Applicant Name: " + Name +
               "\nIncome: " + Income +
               "\nLoan Amount: " + LoanAmount;
    }
}
