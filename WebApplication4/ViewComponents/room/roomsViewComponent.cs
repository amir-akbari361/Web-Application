using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.ViewComponents.room
{
    public class roomsViewComponen : ViewComponent
    {
        //public IViewComponentResult invoke()
        //{
        //    BLL.blroom blr = new BLL.blroom();
        //    return View("rooms", blr.read());
        //}
        public async Task<IViewComponentResult> InvokeAsync()
        {
            BLL.blroom blr = new BLL.blroom();
            return await Task.FromResult((IViewComponentResult)View("rooms", blr.read()));
        }
    }
}
