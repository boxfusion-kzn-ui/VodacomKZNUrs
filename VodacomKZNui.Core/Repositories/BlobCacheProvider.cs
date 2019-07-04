using Akavache;
using System;
using System.Collections.Generic;
using System.Text;

namespace VodacomKZNui.Core.Repositories
{
    public static class BlobCacheProvider
    {
        public static ISecureBlobCache SheshaBlobCache => BlobCache.Secure;
    }
}
