using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace AicbbuuNetworkTools.Services;

public class TracerouteService
{
    public List<(int Hop, string Address, int TimeMs, bool Reached)> Trace(string host, int maxHops = 30)
    {
        var results = new List<(int Hop, string Address, int TimeMs, bool Reached)>();
        try
        {
            int ttl = 1;
            while (ttl <= maxHops)
            {
                using var ping = new Ping();
                var reply = ping.Send(host, 3000, new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, new PingOptions { Ttl = ttl });
                string addr = reply?.Address?.ToString() ?? "*";
                bool reached = reply?.Status == IPStatus.Success || reply?.Status == IPStatus.TtlExpired;
                results.Add((ttl, addr, reply?.RoundtripTime ?? 0, reached && reply?.Status == IPStatus.Success));
                if (reached && reply?.Status == IPStatus.Success) break;
                ttl++;
            }
        }
        catch { /* best-effort */ }
        return results;
    }
}
