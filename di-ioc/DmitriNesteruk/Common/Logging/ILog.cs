using System;

namespace DmitriNesteruk.Common.Logging
{
    public interface ILog: IDisposable
    {
        void Write(string message);
    }
}