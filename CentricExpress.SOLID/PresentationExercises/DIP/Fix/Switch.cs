namespace PresentationExercises.DIP.Fix
{
    public class Switch
    {
        private readonly ISwitchable switchable;
        private bool isOn;

        public Switch(ISwitchable switchable)
        {
            this.switchable = switchable;
        }

        public void Toggle()
        {
            isOn = !isOn;

            if (isOn)
            {
                switchable.TurnOn();
            }
            else
            {
                switchable.TurnOff();
            }
        }
    }
}