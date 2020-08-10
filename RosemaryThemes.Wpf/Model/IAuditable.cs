using System;

namespace RosemaryThemes.Wpf.Model
{
    public interface IAuditable
    {
        DateTime CreatedOn { get; set; }

        IUser CreatedBy { get; set; }

        DateTime? UpdateOn { get; set; }

        IUser UpdatedBy { get; set; }
    }
}
