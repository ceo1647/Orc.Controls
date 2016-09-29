﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IValidationContextTreeNode.cs" company="WildGums">
//   Copyright (c) 2008 - 2016 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Controls
{
    using System.Collections.Generic;
    using Catel.Data;

    public interface IValidationContextTreeNode
    {
        string DisplayName { get; }

        bool IsExpanded { get; set; }

        bool IsVisible { get; set; }

        ValidationResultType? ResultType { get; }

        IEnumerable<IValidationContextTreeNode> Children { get; }
    }
}