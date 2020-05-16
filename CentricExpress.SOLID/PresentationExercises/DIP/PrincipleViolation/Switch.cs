namespace PresentationExercises.DIP.PrincipleViolation
{
    public class Switch
    {
        private readonly Lamp lamp;
        private bool isOn;

        public Switch(Lamp lamp)
        {
            this.lamp = lamp;
        }

        public void Toggle()
        {
            isOn = !isOn;

            if (isOn)
            {
                lamp.TurnOn();
            }
            else
            {
                lamp.TurnOff();
            }
        }
    }
}