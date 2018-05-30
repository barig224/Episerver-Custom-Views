using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace EpiMeetup2018.CustomViews.Controllers
{
    public class DefaultBlockController : BlockController<BlockData>
    {
        public override ActionResult Index(BlockData currentBlock)
        {
            return PartialView($"/Views/{currentBlock.GetOriginalType().Name}/Index.cshtml", currentBlock);
        }
    }
}
