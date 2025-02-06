using TrainDepartureBoard.Entities;

namespace TrainDepartureBoard;

public interface ILdbwsClient
{
    Task<GetDepBoardWithDetailsResponse> GetDepBoardWithDetails(int numRows, string crs, int timeWindow, string filterCrs = "", string filterType = "to", int timeOffset = 0);
}