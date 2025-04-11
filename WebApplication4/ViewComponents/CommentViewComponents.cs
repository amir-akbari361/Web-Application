using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.ViewComponents
{
    public class CommentViewComponents : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            BLL.blcom blr = new BLL.blcom();
            return await Task.FromResult((IViewComponentResult)View("Index2", blr.read()));
        }
    }
}
