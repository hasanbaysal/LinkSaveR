using FontAwesome.Sharp;

using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HB.LinkSaver
{
    public static class LinkManager
    {
        public const string LinksPath = "links.json";
        public const string CategoriesPath = "categories.json";
        public static List<Link> Links = new();
        public static void Control()
        {
            var exampleCategories = new List<string>();
            exampleCategories.Add("categoryTest");
            var exampeLink = new Link()
            {
                Categories = exampleCategories,
                Content = "sample content",
                Description = "sample desc",
                Header = "sample header",
                Id = Guid.NewGuid().ToString()

            };
            if (!File.Exists(LinksPath))
            {
                using var fs = File.Create(Path.Combine( Directory.GetCurrentDirectory() , LinksPath));
                StreamWriter sw = new StreamWriter(fs);
                var list = new List<Link>();
                list.Add(exampeLink);
                sw.Write(JsonSerializer.Serialize(list));
                sw.Close();

            }
            if (!File.Exists(CategoriesPath))
            {
                using var fs = File.Create(Path.Combine(Directory.GetCurrentDirectory(),CategoriesPath));
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(JsonSerializer.Serialize(exampleCategories));
                sw.Close();

            }
            Links = ReadFile();
            CategoryManager.Categories = CategoryManager.GetAll();


        }
        public static List<Link> GetAll()
        {
            Links.Clear();
            Links.AddRange(ReadFile());
            return Links;
        }
        public static bool Add(Link link, bool sendFromApi = false)
        {
            link.Id = Guid.NewGuid().ToString();
            var result = LinkValidation(link,sendFromApi);


            if (result)
            {

            Links.Add(link);
            WriteFile(Links);

            }
            return result;
            //add rule 

        }
        public static void Remove(string id)
        {

            try
            {

                Links.Remove(Links.Where(x => x.Id == id).FirstOrDefault()!);
                WriteFile(Links);
                
            }
            catch (Exception e)
            {

                MessageBox.Show("Error! ");
            }
        }
        public static bool Update(Link link)
        {

            var old = Links.Where(x => x.Id == link.Id).FirstOrDefault()!;
            Links.Remove(old);

            bool result = LinkValidation(link);

            if (!result)
            {
                Links.Add(old);
                return false;
            }

            Links.Add(link);

            WriteFile(Links);

            return true;


        }
        public static void UpdateAll() =>  WriteFile(Links);
          
        public static List<Link> GetLinksByCategories(List<string> categories)
        {

            List<Link> linksResult = new List<Link>();

            foreach (var link in Links)
            {
                var status = true;
                foreach (var item in categories)
                {
                   

                    status = status && link.Categories.Contains(item);
                    if (!status) break;
                }
                if (status)
                    linksResult.Add(link);

                status = true;
            }

            return linksResult.Count !=0 ? linksResult.DistinctBy(x => x.Id).ToList(): linksResult;

        }
        private static bool LinkValidation(Link link, bool sendFromApi = false)
        {
            var con1 = !Links.Any(x => x.Content.ToLower().Trim() == link.Content.ToLower().Trim());
            //var con2 = !Links.Any(x => x.Header == link.Header);
            var con3 = (link.Categories.Count != 0);
            //var result = con1 && con2 && con3;
            var result = con1 && con3;

            var message = string.Empty;
            if (!con1)
                message +=  "This link is already registered!"+ Environment.NewLine;
            //if (!con2)
            //    message +=  "This header is already registered!" +Environment.NewLine;
            if (!con3)
                message += "record must contain at least one category" ;

            if (!result)
            {
                if (sendFromApi)
                {
                Program.MainFrm.BringToTop();

                }
                MessageBox.Show(message, "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            return result;
        }
        private static List<Link> ReadFile()
         => JsonSerializer.Deserialize<List<Link>>(File.ReadAllText(LinksPath))!;
        private static void WriteFile(List<Link> data)
        => File.WriteAllText(LinksPath, JsonSerializer.Serialize(data));

    }

    public static class CategoryManager
    {
         private const string CategoriesPath = "categories.json";
         private static List<string> _categories = new();
         public static List<string> Categories
         {
             get
             {
                 _categories.Sort();
                 return _categories;
             }
             set
             {
                 _categories = value;
        
                 _categories.Sort();
        
                 
             }
         }
        public static bool Add(string category)
        {
            if (Categories.Contains(category))
                return false;


            Categories.Add(category);

            WriteFile(Categories);
            return true;
        }
        public static bool Delete(string category)
        {
            var result =  LinkManager.Links.Where(x=>x.Categories.Contains(category)).Any();
            if (result) return false;


            Categories.Remove(category);
            WriteFile(Categories);

            Categories = ReadFile();
            return true;

        }
        //update!

        public static bool Update(string OldCategory, string newCategory)
        {

            if ( CategoryManager.Categories.Contains(newCategory))
            {
                MessageBox.Show(newCategory + "  alerdy existy");
                return false;
            }

            for (int i = 0; i < LinkManager.Links.Count; i++)
            {
                var temp = LinkManager.Links[i].Categories;
                for (int j = 0; j < temp.Count; j++)
                {
                    if (temp[j].ToLower() == OldCategory.ToLower())
                    {
                        temp[j] = newCategory;
                    }
                }
            }
            LinkManager.UpdateAll();

            Categories.Remove(OldCategory);
            Categories.Add(newCategory);
            WriteFile(Categories);
            Categories = ReadFile();
            return true;
        }

        public static List<string> GetAll()
        {
            Categories = ReadFile();
            return Categories;
        }
        private static List<string> ReadFile()
         => JsonSerializer.Deserialize<List<string>>(File.ReadAllText(CategoriesPath))!;
        private static void WriteFile(List<string> data)
        => File.WriteAllText(CategoriesPath, JsonSerializer.Serialize(data));

    }

}
