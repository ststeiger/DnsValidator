
namespace DnsValidator
{


    class Utils
    {


        public static bool DomainExists(string d)
        {
            try
            {
                System.Net.IPHostEntry hostEntry = System.Net.Dns.GetHostEntry(d);
                System.Console.WriteLine(hostEntry);
                return true;
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            return false;
        }


        public static void DisplayDnsAddresses()
        {
            System.Net.NetworkInformation.NetworkInterface[] adapters = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();
            foreach (System.Net.NetworkInformation.NetworkInterface adapter in adapters)
            {
                if (adapter.OperationalStatus != System.Net.NetworkInformation.OperationalStatus.Up)
                    continue;


                System.Net.NetworkInformation.IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                System.Net.NetworkInformation.IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
                if (dnsServers.Count > 0)
                {
                    System.Console.WriteLine(adapter.Description);
                    foreach (System.Net.IPAddress dns in dnsServers)
                    {
                        System.Console.WriteLine("  DNS Servers ............................. : {0}", dns.ToString());
                    }
                    System.Console.WriteLine();
                }
            }
        } // End Sub DisplayDnsAddresses


        public static System.Net.NetworkInformation.NetworkInterface GetActiveInterface()
        {
            // System.Net.IPHostEntry hostEntry = System.Net.Dns.GetHostEntry(System.Environment.MachineName);

            //foreach (System.Net.IPAddress address in hostEntry.AddressList)
            //{
            //    Console.WriteLine(address);
            //}

            string remoteAddress = "microsoft.com";
            System.Net.Sockets.UdpClient u = new System.Net.Sockets.UdpClient(remoteAddress, 1);
            System.Net.IPAddress localAddr = ((System.Net.IPEndPoint)u.Client.LocalEndPoint).Address;

            foreach (System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus != System.Net.NetworkInformation.OperationalStatus.Up)
                    continue;

                System.Net.NetworkInformation.IPInterfaceProperties ipProps = nic.GetIPProperties();
                // check if localAddr is in ipProps.UnicastAddresses
                foreach (System.Net.NetworkInformation.UnicastIPAddressInformation thisAddress in ipProps.UnicastAddresses)
                {
                    if (thisAddress.Address.Equals(localAddr))
                        return nic;
                } // Next thisAddress

            } // Next nic 

            return null;
        } // End Function GetActiveInterface


        public static System.Collections.Generic.List<System.Net.IPAddress> GetDnsAddresses()
        {
            System.Collections.Generic.List<System.Net.IPAddress> ls =
                new System.Collections.Generic.List<System.Net.IPAddress>();

            System.Net.NetworkInformation.NetworkInterface adapter = GetActiveInterface();


            System.Net.NetworkInformation.IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
            System.Net.NetworkInformation.IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
            if (dnsServers.Count > 0)
            {
                System.Console.WriteLine(adapter.Description);
                foreach (System.Net.IPAddress dns in dnsServers)
                {
                    ls.Add(dns);
                    System.Console.WriteLine("  DNS Servers ............................. : {0}", dns.ToString());
                }
                System.Console.WriteLine();
            } // End if (dnsServers.Count > 0)

            return ls;
        } // End Function GetDnsAddresses 


    }


}
