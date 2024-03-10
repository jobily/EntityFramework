﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.ObjectModel;

namespace Microsoft.EntityFrameworkCore.TestModels.ManyToManyModel;

#nullable disable

public class UnidirectionalGeneratedKeysLeft
{
    public virtual int Id { get; set; }
    public virtual string Name { get; set; }

    public virtual ICollection<UnidirectionalGeneratedKeysRight> Rights { get; } =
        new ObservableCollection<UnidirectionalGeneratedKeysRight>();
}
