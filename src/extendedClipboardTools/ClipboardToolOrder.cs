using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extendedClipboardTools
{
    /// <summary>
    /// clipboard tool order (priority) define list
    /// </summary>
    class ClipboardToolOrder : List<ClipboardToolOrderEntry>
    {
        /// <summary>
        /// write order to file
        /// </summary>
        /// <param name="p">filepath</param>
        public void WriteToFile(string p)
        {
            System.IO.File.WriteAllLines(p, this.Select(x => x.ToOrderListString()));
        }

        /// <summary>
        /// read order from file
        /// </summary>
        /// <param name="p">filepath</param>
        /// <returns></returns>
        public static ClipboardToolOrder ReadFromFile(string p)
        {
            try
            {
                var l = System.IO.File.ReadAllLines(p);
                var ret = new ClipboardToolOrder();
                foreach(var lin in l)
                {
                    var obj = ClipboardToolOrderEntry.FromOrderListString(lin);
                    if (obj != null)
                    {
                        ret.Add(obj);
                    }
                    return ret;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return new ClipboardToolOrder(); 
        }
    }

    /// <summary>
    /// entry of CLipboardToolOrder
    /// </summary>
    class ClipboardToolOrderEntry
    {
        /// <summary>
        /// name of tool(filename)
        /// </summary>
        public string ToolName { get; set; }

        /// <summary>
        /// hash value for update/falsify script
        /// </summary>
        public string SHA1 { get; set; }

        /// <summary>
        /// state of tool
        /// </summary>
        public ToolState State { get; set; }

        /// <summary>
        /// toString as order list format
        /// </summary>
        /// <returns></returns>
        public string ToOrderListString()
        {
            return $"{State}\t{SHA1}\t{ToolName}";
        }

        /// <summary>
        /// fromString as order list format
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static ClipboardToolOrderEntry FromOrderListString(string s)
        {
            var t = s.Split('\t');
            if (t.Length >= 3)
            {
                var obj = new ClipboardToolOrderEntry();
                try
                {
                    obj.State = (ToolState)Enum.Parse(typeof(ToolState), t[0]);
                    obj.SHA1 = t[1];
                    obj.ToolName = t[2];
                }
                catch
                {
                    return null;
                }
                return obj;
            }
            return null;
        }
    }
}
