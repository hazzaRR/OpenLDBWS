using System.Xml;
using System.Xml.Serialization;
using TrainDepartureBoard.Entities;
using System.Text;

namespace TrainDepartureBoard;
public class LdbwsClient : ILdbwsClient
{
    private readonly string _apiKey;
    private readonly string _url;
    public LdbwsClient(string apiKey)
    {
        _apiKey = apiKey;
        _url = "https://lite.realtime.nationalrail.co.uk/OpenLDBWS/ldb12.asmx";
    }
    public LdbwsClient(string apiKey, string url)
    {
        _apiKey = apiKey;
        _url = url;
    }

    private static T? DeserialiseSoapResponse<T>(string xml) 
    {
        XmlSerializer serializer = new(typeof(SoapEnvelope));

        SoapEnvelope envelope;

        using (StringReader reader = new(xml))
        {
            envelope = (SoapEnvelope)(serializer.Deserialize(reader));
        }
    
        XmlElement bodyContent = envelope.Body.Content;

        serializer = new(typeof(T));

        T content;

        using (StringReader reader = new(bodyContent.OuterXml))
        {
            content = (T)(serializer.Deserialize(reader));
        }

        return content;
    }

    private async Task<string> SendSoapReqiest(string requestBody)
    {

        string soapRequest = $@"
        <soap:Envelope xmlns:soap=""http://www.w3.org/2003/05/soap-envelope"" xmlns:typ=""http://thalesgroup.com/RTTI/2013-11-28/Token/types"" xmlns:ldb=""http://thalesgroup.com/RTTI/2021-11-01/ldb/"">
        <soap:Header>
            <typ:AccessToken>
                <typ:TokenValue>{_apiKey}</typ:TokenValue>
            </typ:AccessToken>
        </soap:Header>
        <soap:Body>
        {requestBody}
        </soap:Body>
        </soap:Envelope>";


        using (HttpClient client = new())
        {
            HttpRequestMessage request = new(HttpMethod.Post, _url)
            {
                Content = new StringContent(soapRequest, Encoding.UTF8, "text/xml")
            };

            HttpResponseMessage response = await client.SendAsync(request);
            string responseBody = await response.Content.ReadAsStringAsync();

            return responseBody;
        }

    }

    public async Task<GetDepBoardWithDetailsResponse> GetDepBoardWithDetails(int numRows, string crs, string filterCrs = "", string filterType = "to", int timeOffset = 0, int timeWindow = 120)
    {
        string soapRequest = $@"
            <ldb:GetDepBoardWithDetailsRequest>
                <ldb:numRows>{numRows}</ldb:numRows>
                <ldb:crs>{crs}</ldb:crs>
                <ldb:filterCrs>{filterCrs}</ldb:filterCrs>
                <ldb:filterType>{filterType}</ldb:filterType>
                <ldb:timeOffset>{timeOffset}</ldb:timeOffset>
                <ldb:timeWindow>{timeWindow}</ldb:timeWindow>
            </ldb:GetDepBoardWithDetailsRequest>";


        string response = await SendSoapReqiest(soapRequest);

        if (response != null)
        {
            return DeserialiseSoapResponse<GetDepBoardWithDetailsResponse>(response);
        }

        throw new Exception("Unable to get response from api");
    }

    public Task<GetArrBoardWithDetailsResponse> GetArrBoardWithDetails(int numRows, string crs, string filterCrs = "", string filterType = "to", int timeOffset = 0, int timeWindow = 120)
    {
        throw new NotImplementedException();
    }

    public Task<GetArrDepBoardWithDetailsResponse> GetArrDepBoardWithDetails(int numRows, string crs, string filterCrs = "", string filterType = "to", int timeOffset = 0, int timeWindow = 120)
    {
        throw new NotImplementedException();
    }

    public Task<GetArrivalBoardResponse> GetArrivalBoard(int numRows, string crs, string filterCrs = "", string filterType = "to", int timeOffset = 0, int timeWindow = 120)
    {
        throw new NotImplementedException();
    }

    public Task<GetArrivalDepartureBoardResponse> GetArrivalDepartureBoard(int numRows, string crs, string filterCrs = "", string filterType = "to", int timeOffset = 0, int timeWindow = 120)
    {
        throw new NotImplementedException();
    }

    public Task<GetDepartureBoardResponse> GetDepartureBoard(int numRows, string crs, string filterCrs = "", string filterType = "to", int timeOffset = 0, int timeWindow = 120)
    {
        throw new NotImplementedException();
    }

    public Task<GetFastestDeparturesResponse> GetFastestDepartures(string crs, List<string> filterCrsList, int timeOffset = 0, int timeWindow = 120)
    {
        throw new NotImplementedException();
    }

    public Task<GetFastestDeparturesWithDetailsResponse> GetFastestDeparturesWithDetails(string crs, List<string> filterCrsList, int timeOffset = 0, int timeWindow = 120)
    {
        throw new NotImplementedException();
    }

    public Task<GetNextDeparturesResponse> GetNextDepartures(string crs, List<string> filterCrsList, int timeOffset = 0, int timeWindow = 120)
    {
        throw new NotImplementedException();
    }

    public Task<GetNextDeparturesWithDetailsResponse> GetNextDeparturesWithDetails(string crs, List<string> filterCrsList, int timeOffset = 0, int timeWindow = 120)
    {
        throw new NotImplementedException();
    }

    public Task<GetServiceDetailsResponse> GetServiceDetails(string serviceId)
    {
        throw new NotImplementedException();
    }
}