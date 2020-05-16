namespace PresentationExercises.ISP.PrincipleViolation
{
    public class EconomicPrinter : ISmartDevice
    {
        public void Print()
        {
            // print
        }

        public void Fax()
        {
            throw new System.NotImplementedException();
        }

        public void Scan()
        {
            throw new System.NotImplementedException();
        }
    }
}