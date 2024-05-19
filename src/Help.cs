using System;

namespace GeometryCalculator
{
    public class Help
    {
        public static void ShowHelp()
        {
            string commandsMessage = "Commands:";
            string spaceCommandMessage = "When you press the 'space' key while text is being printed, the entire text will be displayed immediately.";
            string dash = "|--------------------------|";

            int maxWidth = dash.Length - 4; 
            string spaceCommandDisplay = $" 'space' - {spaceCommandMessage} ";
            string paddedMessage = spaceCommandDisplay.PadRight(maxWidth);

            string verticalBar = $"|{paddedMessage}|";

            Features.WriteMessage(commandsMessage);
            Features.WriteMessage(dash);
            Features.WriteMessage(verticalBar);
            Features.WriteMessage(dash);
        }
    }
}