﻿using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace Positron.Server
{
    class PositronResponse : IHttpResponseFeature
    {
        public void OnStarting(Func<object, Task> callback, object state)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted(Func<object, Task> callback, object state)
        {
            throw new NotImplementedException();
        }

        public int StatusCode { get; set; }
        public string ReasonPhrase { get; set; }
        public IHeaderDictionary Headers { get; set; }
        public Stream Body { get; set; }
        public bool HasStarted => false;
    }
}