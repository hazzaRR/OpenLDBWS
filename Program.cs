using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using TrainDepartureBoard;
using TrainDepartureBoard.Entities;

string departureStationCode = "COL";
string destinationStationCode = "LST";

string url = "https://lite.realtime.nationalrail.co.uk/OpenLDBWS/ldb12.asmx";

string soapRequest = $@"
<soap:Envelope xmlns:soap=""http://www.w3.org/2003/05/soap-envelope"" xmlns:typ=""http://thalesgroup.com/RTTI/2013-11-28/Token/types"" xmlns:ldb=""http://thalesgroup.com/RTTI/2021-11-01/ldb/"">
   <soap:Header>
      <typ:AccessToken>
         <typ:TokenValue>{apiKey}</typ:TokenValue>
      </typ:AccessToken>
   </soap:Header>
   <soap:Body>
      <ldb:GetDepBoardWithDetailsRequest>
         <ldb:numRows>10</ldb:numRows>
         <ldb:crs>{departureStationCode}</ldb:crs>
         <ldb:filterCrs>{destinationStationCode}</ldb:filterCrs>
         <ldb:filterType>to</ldb:filterType>
         <ldb:timeOffset>0</ldb:timeOffset>
         <ldb:timeWindow>120</ldb:timeWindow>
      </ldb:GetDepBoardWithDetailsRequest>
   </soap:Body>
</soap:Envelope>";

using (HttpClient client = new())
{
    HttpRequestMessage request = new(HttpMethod.Post, url)
    {
        Content = new StringContent(soapRequest, Encoding.UTF8, "text/xml")
    };

    HttpResponseMessage response = await client.SendAsync(request);
    string responseBody = await response.Content.ReadAsStringAsync();
    XmlSerializer serializer = new(typeof(SoapEnvelope));

   SoapEnvelope envelope;

   using (StringReader reader = new(responseBody))
   {
      envelope = (SoapEnvelope)(serializer.Deserialize(reader));
   }


    XmlElement bodyContent = envelope.Body.Content;


   //  GetDepBoardWithDetailsResponse detailsResponse = (GetDepBoardWithDetailsResponse) stationBoard.Body.Content;
   // //  Console.WriteLine(responseBody);
    Console.WriteLine(bodyContent.OuterXml);

   serializer = new(typeof(GetDepBoardWithDetailsResponse));

   GetDepBoardWithDetailsResponse stationBoard;

   using (StringReader reader = new(bodyContent.OuterXml))
   {
      stationBoard = (GetDepBoardWithDetailsResponse)(serializer.Deserialize(reader));
   }

   Console.WriteLine(stationBoard.StationBoardWithDetails.FilterLocationName);

}