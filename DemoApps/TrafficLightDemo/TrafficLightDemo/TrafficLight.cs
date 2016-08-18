namespace TrafficLightDemo
{
    /// <summary>
    /// class object representing a traffic light
    /// </summary>
    public class TrafficLight
    {
        /// <summary>
        /// property providing the color of the light. 
        /// Setting the value is only done through the method.
        /// </summary>
        public TrafficLightColor CurrentColor { get; private set; }

        /// <summary>
        /// constructor
        /// </summary>
        public TrafficLight()
        {
            CurrentColor = TrafficLightColor.Red;
        }

        /// <summary>
        /// method to change the light color
        /// </summary>
        public void ChangeColor()
        {
            // what color is the light now determines it's next color
            switch (CurrentColor)
            {
                case TrafficLightColor.Red:
                    CurrentColor = TrafficLightColor.Green;
                    break;
                case TrafficLightColor.Yellow:
                    CurrentColor = TrafficLightColor.Red;
                    break;
                default:
                    CurrentColor = TrafficLightColor.Yellow;
                    break;
            }
        }
    }
}
