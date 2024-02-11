using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppArchitecture.Data
{
    public static class SimpleData
    {
        public static void InitData(Context context)
        {
            if (!context.Directory.Any())
            {
                context.Directory.Add(new Entityes.Directory()
                {
                    Title = "First",
                    Html = "<b>First directory content</b>"
                });
                context.Directory.Add(new Entityes.Directory()
                {
                    Title = "Second",
                    Html = "<b>Second directory content</b>"
                });
                context.SaveChanges();
            }

            if (!context.Material.Any())
            {
                context.Material.Add(new Entityes.Material()
                {
                    Title = "First",
                    Html = "<b>First material content</b>",
                    DirectoryId = context.Directory.OrderBy(e => e.Id).Last().Id
                });
                context.Material.Add(new Entityes.Material()
                {
                    Title = "Second",
                    Html = "<b>Second material content</b>",
                    DirectoryId = context.Directory.OrderBy(e => e.Id).First().Id
                });

                context.SaveChanges();
            }
        }
    }
}
