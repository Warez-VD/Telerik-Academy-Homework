namespace ParseURL
{
    using System;
    using System.Text;

    class ParseURL
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string protocol = "[protocol] = ";
            string server = "[server] = ";
            string resource = "[resource] = ";
            var result = new StringBuilder();
            int startIndex = 0;
            input = input.Insert(0, " ");
            int endIndex = input.IndexOf(':', startIndex);
            string protocolName = input.Substring(startIndex, endIndex).Trim(' ');
            result.AppendLine(protocol + protocolName);
            input = input.Remove(startIndex, endIndex + 3);
            endIndex = input.IndexOf('/', startIndex);
            string serverName = input.Substring(startIndex, endIndex).Trim('/');
            input = input.Remove(startIndex, endIndex);
            result.AppendLine(server + serverName);
            result.AppendLine(resource + input);

            Console.WriteLine(result.ToString().Trim());
        }
    }
}
