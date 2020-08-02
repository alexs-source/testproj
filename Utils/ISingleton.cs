using System.Collections.Generic;
using testproj.Models;

namespace testproj.Utils
{
    public interface ISingleton
    {
        public List<Storage> GetStorages();
    }
}