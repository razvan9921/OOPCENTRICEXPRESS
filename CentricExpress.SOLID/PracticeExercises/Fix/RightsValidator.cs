using System.Linq;
using PracticeExercises.Fix.Rights;

namespace PracticeExercises.Fix
{
    public class RightsValidator
    {
        public bool ValidateAdminRight(IRights rights)
        {
            return rights.GetValues().Any(right => right.Equals("admin"));
        }

        public bool ValidateWriteRight(IRights rights)
        {
            return rights.GetValues().Any(right => right.Equals("write"));
        }
    }
}