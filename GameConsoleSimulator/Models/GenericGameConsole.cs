
namespace GameConsoleSimulator.Models
{
    public class GenericGameConsole : GameConsole
    {   
        public override AVInterface VideoConnectorType
        {
            get
            {
                return AVInterface.Other;
            }
        }

        public override void StartUp()
        {
            throw new System.NotImplementedException();
        }
    }
}