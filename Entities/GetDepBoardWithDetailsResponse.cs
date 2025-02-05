using System.Xml.Serialization;
namespace TrainDepartureBoard.Entities;

[XmlRoot(ElementName = "GetDepBoardWithDetailsResponse", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/")]
public class GetDepBoardWithDetailsResponse
{

    [XmlElement(ElementName = "GetStationBoardResult")]
    public required StationBoardWithDetails StationBoardWithDetails { get; set; }
}