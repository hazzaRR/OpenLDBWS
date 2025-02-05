namespace TrainDepartureBoard.Entities;

public class CallingPoint
{
    public string LocationName { get; set; } = "";
    public string Crs { get; set; } = "";
    public TimeSpan St { get; set; }
    public string Et { get; set; }
    public int Length { get; set; }
    public Formation Formation { get; set; }
}