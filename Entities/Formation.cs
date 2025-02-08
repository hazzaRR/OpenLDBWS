using System.Xml.Serialization;
namespace TrainDepartureBoard.Entities;
public class Formation 
{


    [XmlElement("loadingCategory")]
    public LoadingCategory? LoadingCategory {get; set; }
    [XmlArray("coaches")]
    [XmlArrayItem("coach")]
    public List<Coach> Coaches {get; set;} = [];

}
