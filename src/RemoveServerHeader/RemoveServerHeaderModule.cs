using System;
using System.Web;

namespace RemoveServerHeader
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class RemoveServerHeaderModule : IHttpModule
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public void Init(HttpApplication context)
        {
            context.BeginRequest += BeginRequest;
        }

        private void BeginRequest(object sender, EventArgs e)
        {
            var httpApplication = sender as HttpApplication;
            httpApplication?.Context?.Response.Headers.Remove("Server");
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose() { }
    }
}
