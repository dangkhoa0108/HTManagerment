using System;

namespace HTManagerment.Data.Common.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { set; get; }

        DateTime DateModified { set; get; }

        int Version { get; set; }
    }
}
