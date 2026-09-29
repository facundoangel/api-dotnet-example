using System;
using System.Collections.Generic;

namespace test.Models;

public partial class Migration
{
    public string MigrationId { get; set; } = null!;

    public string ProductVersion { get; set; } = null!;
}
