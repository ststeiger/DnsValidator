
using DnDns;
using DnDns.Query;
using DnDns.Records;
using DnDns.Enums;
using DnDns.Security;


namespace DnsValidator
{



    class DnDnsTest
    {


        public static void DnDnsForwardLookup()
        {
            string dnsServer = "192.168.0.1";
            dnsServer = Utils.GetDnsAddresses()[0].ToString();

            DnsQueryRequest request = new DnsQueryRequest();
            DnsQueryResponse response = request.Resolve(dnsServer, "www.google.com", NsType.A, NsClass.INET, System.Net.Sockets.ProtocolType.Udp, null);

            System.Console.WriteLine("Bytes received: " + response.BytesReceived);

            // Enumerate the Answer Records
            System.Console.WriteLine("Answers:");
            foreach (IDnsRecord record in response.Answers)
            {
                System.Console.WriteLine(record.Answer);
                System.Console.WriteLine("  |--- RDATA Field Length: " + record.DnsHeader.DataLength);
                System.Console.WriteLine("  |--- Name: " + record.DnsHeader.Name);
                System.Console.WriteLine("  |--- NS Class: " + record.DnsHeader.NsClass);
                System.Console.WriteLine("  |--- NS Type: " + record.DnsHeader.NsType);
                System.Console.WriteLine("  |--- TTL: " + record.DnsHeader.TimeToLive);
                System.Console.WriteLine();
            } // Next record 

            System.Console.WriteLine(response.Answers);
            //System.Console.ReadLine();
        } // End Sub DnDnsForwardLookup

    }


}
