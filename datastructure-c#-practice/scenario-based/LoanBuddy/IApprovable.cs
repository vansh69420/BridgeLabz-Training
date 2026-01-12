public interface IApprovable
{
    bool ApproveLoan(Applicant applicant);
    double CalculateEMI(double principal, double rate, int term);
}
