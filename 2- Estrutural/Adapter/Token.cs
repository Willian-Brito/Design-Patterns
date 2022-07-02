using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter
{
    public class Token
    {
        private string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiSm9obiBEb2UiLCJpYXQiOjE1MTYyMzkwMjJ9.900F-UEKYX6gbzljRwncitDC1RJysNamFGVcY2SCse4";

        public string GetTokoen()
        {
            return token;
        }
    }
}