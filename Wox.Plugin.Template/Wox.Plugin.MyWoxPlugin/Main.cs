using System;
using System.Collections.Generic;

namespace Wox.Plugin.MyWoxPlugin
{
    public class MyWoxPlugin : IPlugin
    {
        private PluginInitContext _context;

        public void Init(PluginInitContext context)
        {
            _context = context;
        }

        public List<Result> Query(Query query)
        {
            return new List<Result>();
        }
    }
}