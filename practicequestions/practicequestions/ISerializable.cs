using System;
using System.IO;

namespace practicequestions
{
    interface ISerializable
    {
        void SaveToFile(string filename);
    }
}
