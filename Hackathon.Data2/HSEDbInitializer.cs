using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Hackathon.Data.Entities;

namespace Hackathon.Data
{
  public class HSEDbInitializer
  {
    private HSEContext _ctx;

    public HSEDbInitializer(HSEContext ctx)
    {
      _ctx = ctx;
    }
  }
}
