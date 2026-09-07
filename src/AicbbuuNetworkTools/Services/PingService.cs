using System.Net.NetworkInformation;

namespace AicbbuuNetworkTools.Services;

public class PingService
{
    public PingReply? SendPing(string hostNameOrAddress, int timeoutMs = 3000)
    {
        try
        {
            using var ping = new Ping();
            return ping.Send(hostNameOrAddress, timeoutMs);
        }
        catch
        {
            return null;
        }
    }
}
