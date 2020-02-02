namespace XPlaneConnector
{
    public sealed class XPlaneCommand
    {
        private readonly string command;
        private readonly string description;

        public string Command { get { return command; } }
        public string Description { get { return description; } }

        public XPlaneCommand(string command, string description)
        {
            this.command = command;
            this.description = description;
        }
    }
}

