using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace restArest;

public partial class User
{
    [Key]
    public long? Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;
}
