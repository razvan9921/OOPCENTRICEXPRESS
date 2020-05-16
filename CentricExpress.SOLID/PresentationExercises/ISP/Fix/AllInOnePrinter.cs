namespace PresentationExercises.ISP.Fix
{
    public class AllInOnePrinter : IPrinter, IFax, IScanner
    {
        public void Print()
        {
            // print
        }

        public void Fax()
        {
            // fax
        }

        public void Scan()
        {
            // scan
        }
    }
}