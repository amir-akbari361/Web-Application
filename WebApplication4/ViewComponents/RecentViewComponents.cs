using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.ViewComponents
{
    public class RecentViewComponents : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            BLL.blroom blr = new BLL.blroom();
            return await Task.FromResult((IViewComponentResult)View("Index", blr.read()));
        }
    }
}
