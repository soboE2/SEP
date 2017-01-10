using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP.Service.Helpers
{
    public class DroolsDotnetUtil
    {
        public static java.io.StringReader getJavaStringReaderFromSystemStream(System.IO.Stream stream)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(stream);
            StringBuilder bldr = new StringBuilder();
            String str = null;
            while ((str = reader.ReadLine()) != null)
            {
                bldr.Append(str);
                bldr.Append("\n");
            }
            String ruleFile = bldr.ToString();
            return new java.io.StringReader(ruleFile);
        }

        public static java.io.InputStream getJavaInputStreamFromSystemStream(System.IO.Stream stream)
        {
            byte[] buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);
            java.io.ByteArrayInputStream byteStreams = new java.io.ByteArrayInputStream(buffer);
            return byteStreams;
        }
    }
}
