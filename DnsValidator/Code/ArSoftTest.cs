
using ARSoft.Tools.Net.Dns;


namespace DnsValidator
{


    class ArSoftTest
    {


        public static void GetMailExchangers()
        {
            DnsMessage dnsMessage = DnsClient.Default.Resolve("example.com", RecordType.Mx);
            if ((dnsMessage == null) || ((dnsMessage.ReturnCode != ReturnCode.NoError) && (dnsMessage.ReturnCode != ReturnCode.NxDomain)))
            {
                throw new System.Exception("DNS request failed");
            }
            else
            {
                foreach (DnsRecordBase dnsRecord in dnsMessage.AnswerRecords)
                {
                    MxRecord mxRecord = dnsRecord as MxRecord;
                    if (mxRecord != null)
                    {
                        System.Console.WriteLine(mxRecord.ExchangeDomainName);
                    }
                }
            }
        }


        // https://docs.ar-soft.de/arsoft.tools.net/#DNS%20Client.html
        public static void GetReverseLookupAddress()
        {
            string rev = ARSoft.Tools.Net.IPAddressExtension.GetReverseLookupAddress(System.Net.IPAddress.Parse("192.0.2.1"));

            DnsMessage dnsMessage = DnsClient.Default.Resolve(rev, RecordType.Ptr);
            if ((dnsMessage == null) || ((dnsMessage.ReturnCode != ReturnCode.NoError) && (dnsMessage.ReturnCode != ReturnCode.NxDomain)))
            {
                throw new System.Exception("DNS request failed");
            }
            else
            {
                foreach (DnsRecordBase dnsRecord in dnsMessage.AnswerRecords)
                {
                    PtrRecord ptrRecord = dnsRecord as PtrRecord;
                    if (ptrRecord != null)
                    {
                        System.Console.WriteLine(ptrRecord.PointerDomainName);
                    }
                }
            }
        }


        public static bool DnsEntryExists()
        {
            DnsClient CustomDnsClient = new DnsClient(Utils.GetDnsAddresses()[0], 10000);

            //DnsMessage dnsMessage = DnsClient.Default.Resolve("www.example.com", RecordType.A);
            //DnsMessage dnsMessage = CustomDnsClient.Resolve("www.example.com", RecordType.A);
            DnsMessage dnsMessage = CustomDnsClient.Resolve("www.fjasldfjalsdjflasjdf.com", RecordType.A);
            if ((dnsMessage == null) || ((dnsMessage.ReturnCode != ReturnCode.NoError) && (dnsMessage.ReturnCode != ReturnCode.NxDomain)))
            {
                throw new System.Exception("DNS request failed");
            }
            else
            {
                foreach (DnsRecordBase dnsRecord in dnsMessage.AnswerRecords)
                {
                    
                    ARecord aRecord = dnsRecord as ARecord;
                    if (aRecord != null)
                    {
                        System.Console.WriteLine(aRecord.Address.ToString());
                        return true;
                    }
                }
            }

            return false;
        }


        public static void ForwardLookup()
        {
            DnsClient CustomDnsClient = new DnsClient(Utils.GetDnsAddresses()[0], 10000);

            //DnsMessage dnsMessage = DnsClient.Default.Resolve("www.example.com", RecordType.A);
            //DnsMessage dnsMessage = CustomDnsClient.Resolve("www.example.com", RecordType.A);
            DnsMessage dnsMessage = CustomDnsClient.Resolve("www.fjasldfjalsdjflasjdf.com", RecordType.A);
            if ((dnsMessage == null) || ((dnsMessage.ReturnCode != ReturnCode.NoError) && (dnsMessage.ReturnCode != ReturnCode.NxDomain)))
            {
                throw new System.Exception("DNS request failed");
            }
            else
            {
                foreach (DnsRecordBase dnsRecord in dnsMessage.AnswerRecords)
                {
                    ARecord aRecord = dnsRecord as ARecord;
                    if (aRecord != null)
                    {
                        System.Console.WriteLine(aRecord.Address.ToString());
                    }
                }
            }
        }



    }
}
