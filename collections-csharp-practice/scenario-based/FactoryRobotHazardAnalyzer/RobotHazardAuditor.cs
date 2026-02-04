public class RobotHazardAuditor
{
    public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
    {
        ValidateArmPrecision(armPrecision);
        ValidateWorkerDensity(workerDensity);

        double machineRiskFactor = GetMachineRiskFactor(machineryState);

        double hazardRisk =
            ((1.0 - armPrecision) * 15.0) +
            (workerDensity * machineRiskFactor);

        return hazardRisk;
    }

    private void ValidateArmPrecision(double armPrecision)
    {
        if (armPrecision < 0.0 || armPrecision > 1.0)
        {
            throw new RobotSafetyException("Error: Arm precision must be 0.0-1.0");
        }
    }

    private void ValidateWorkerDensity(int workerDensity)
    {
        if (workerDensity < 1 || workerDensity > 20)
        {
            throw new RobotSafetyException("Error: Worker density must be 1-20");
        }
    }

    private double GetMachineRiskFactor(string machineryState)
    {
        if (machineryState == "Worn")
        {
            return 1.3;
        }
        else if (machineryState == "Faulty")
        {
            return 2.0;
        }
        else if (machineryState == "Critical")
        {
            return 3.0;
        }
        else
        {
            throw new RobotSafetyException("Error: Unsupported machinery state");
        }
    }
}
