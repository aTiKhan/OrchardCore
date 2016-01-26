﻿using Orchard.DisplayManagement.Descriptors;
using System;

namespace Orchard.DisplayManagement.Handlers
{
    /// <summary>
    /// Represents a context object that is used to build and place a list of shape representing
    /// something that has to be displayed.
    /// </summary>
    public interface IBuildShapeContext
    {
        dynamic Shape { get; }
        IShapeFactory ShapeFactory { get; }
        dynamic New { get; }
        IShape Layout { get; set; }
        string GroupId { get; }
        Func<string, string, string, PlacementInfo> FindPlacement { get; set; }
    }
}
