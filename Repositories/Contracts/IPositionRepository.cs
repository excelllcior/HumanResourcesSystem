using System.Collections.Generic;
using HumanResourcesSystem.Models;

namespace HumanResourcesSystem.Repositories
{
    public interface IPositionRepository
    {
        List<Position> GetPositions();
        Position GetPosition(int positionId);
        void InsertPosition(Position position);
        void UpdatePosition(Position position);
        void DeletePosition(int positionId);
    }
}
