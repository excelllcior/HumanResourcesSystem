using System.Collections.Generic;
using HumanResourcesSystem.Models;

namespace HumanResourcesSystem.Repositories.Contracts
{
    public interface ILevelRepository
    {
        List<Level> GetLevels();
        Level GetLevel(int levelId);
        void InsertLevel(Level level);
        void UpdateLevel(Level level);
        void DeleteLevel(int levelId);
    }
}
