using System;
using System.Web;

namespace RemoveServerHeader
{
    public sealed class RemoveServerHeaderModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.BeginRequest += BeginRequest;
        }

        private void BeginRequest(object sender, EventArgs e)
        {
            var httpApplication = sender as HttpApplication;
            httpApplication?.Context?.Response.Headers.Remove("Server");
        }

        public void Dispose() { }
    }
}