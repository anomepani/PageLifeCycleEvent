using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycleEvent
{
    public partial class PageEvents : System.Web.UI.Page
    {
        List<string> lifeCycleEvent = new List<string>();
        public PageEvents()
        {
            lifeCycleEvent.Add("Constructor");
            Debug.WriteLine("Constructor");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Page_Load");
            lifeCycleEvent.Add("Page_Load");
        }

        protected override void OnPreInit(EventArgs e)
        {
            Debug.WriteLine("OnPreInit");
            base.OnPreInit(e);
            lifeCycleEvent.Add("OnPreInit");
        }


        protected override void OnInit(EventArgs e)
        {
            Debug.WriteLine("OnInit");
            base.OnInit(e);
            lifeCycleEvent.Add("OnInit");
        }
        protected override void OnInitComplete(EventArgs e)
        {
            Debug.WriteLine("OnInitComplete");
            base.OnInitComplete(e);
            lifeCycleEvent.Add("OnInitComplete");
        }
        protected override void OnPreLoad(EventArgs e)
        {
            Debug.WriteLine("OnPreLoad");
            base.OnPreLoad(e);
            lifeCycleEvent.Add("OnPreLoad");
        }
        protected override void OnLoadComplete(EventArgs e)
        {
            Debug.WriteLine("OnLoadComplete");
            base.OnLoadComplete(e);
            lifeCycleEvent.Add("OnLoadComplete");
        }
        protected override void OnPreRender(EventArgs e)
        {
            Debug.WriteLine("OnPreRender");
            base.OnPreRender(e);
            lifeCycleEvent.Add("OnPreRender");
        }
        protected override void OnPreRenderComplete(EventArgs e)
        {
            Debug.WriteLine("OnPreRenderComplete");
            base.OnPreRenderComplete(e);
            lifeCycleEvent.Add("OnPreRenderComplete");
        }

        protected override void OnSaveStateComplete(EventArgs e)
        {
            Debug.WriteLine("OnSaveStateComplete");
            base.OnSaveStateComplete(e);
            lifeCycleEvent.Add("OnSaveStateComplete");
        }
        protected override void Render(HtmlTextWriter writer)
        {
            Debug.WriteLine("Render");
            lifeCycleEvent.Add("Render");
            writer.WriteLine("<h3>Page life cycle events</h3>");
            writer.WriteLine("<ul>");
            foreach (var item in lifeCycleEvent)
            {
                writer.WriteLine("<li>" + item + "</li>");
            }
            writer.WriteLine("</ul>");

            base.Render(writer);
        }
        protected override void OnUnload(EventArgs e)
        {
            Debug.WriteLine("OnUnload");
            lifeCycleEvent.Add("OnUnload");
            base.OnUnload(e);
        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("ddlCountry_SelectedIndexChanged");
            lifeCycleEvent.Add("ddlCountry_SelectedIndexChanged");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("btnSave_Click");
            lifeCycleEvent.Add("btnSave_Click");
        }

        protected void btnSave_Init(object sender, EventArgs e)
        {

        }

        protected void btnSave_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("btnSave_Load");
            lifeCycleEvent.Add("btnSave_Load");
        }

        protected void btnSave_PreRender(object sender, EventArgs e)
        {
            Debug.WriteLine("btnSave_PreRender");
            lifeCycleEvent.Add("btnSave_PreRender");
        }

        protected void ddlCountry_Init(object sender, EventArgs e)
        {
            Debug.WriteLine("ddlCountry_Init");
            lifeCycleEvent.Add("ddlCountry_Init");
        }

        protected void ddlCountry_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("ddlCountry_Load");
            lifeCycleEvent.Add("ddlCountry_Load");
        }

        protected void ddlCountry_PreRender(object sender, EventArgs e)
        {
            Debug.WriteLine("ddlCountry_PreRender");
            lifeCycleEvent.Add("ddlCountry_PreRender");
        }
    }
}