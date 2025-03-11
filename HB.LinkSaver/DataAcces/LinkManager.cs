using HB.LinkSaver.DataAcces;
using System.Text.Json;

namespace HB.LinkSaver
{
    public static class LinkManager
    {
        public const string LinksPath = "links.json";
        public const string CategoriesPath = "categories.json";
        public const string MailSettingsPath = "MailSettings.json";

        public static List<Link> Links = new();

        public static void Control()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var exampleCategories = new List<Category>();

            exampleCategories.Add(new() { CategorGroupName = "SampleGroup", SubCategories = new() { "SampleCategory", "SampleCategory2" } });

            var exampeLink = new Link()
            {
                Categories = exampleCategories.First().SubCategories,
                Content = "sample content",
                Description = "sample desc",
                Header = "sample header",
                Id = Guid.NewGuid().ToString()
            };
            if (!File.Exists(LinksPath))
            {
                using var fs = File.Create(Path.Combine(Directory.GetCurrentDirectory(), LinksPath));
                StreamWriter sw = new StreamWriter(fs);
                var list = new List<Link>();
                list.Add(exampeLink);
                sw.Write(JsonSerializer.Serialize(list, options));
                sw.Close();

            }
            if (!File.Exists(MailSettingsPath))
            {
                using var fs = File.Create(Path.Combine(Directory.GetCurrentDirectory(), MailSettingsPath));
                StreamWriter sw = new StreamWriter(fs);
                var data = new MailSettingsOption() { AppPassword = "none", MailAddress = "none", PortNumber = 0, StmpServer = "none", RecipientMailAddress = "none" };
                sw.Write(JsonSerializer.Serialize(data, options));
                sw.Close();

            }
            if (!File.Exists(CategoriesPath))
            {
                using var fs = File.Create(Path.Combine(Directory.GetCurrentDirectory(), CategoriesPath));
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(JsonSerializer.Serialize(exampleCategories, options));
                sw.Close();

            }
            Links = ReadFile();

            var categories = CategoryManager.Categories;
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
            var result = LinkValidation(link, sendFromApi);


            if (result)
            {

                Links.Add(link);
                WriteFile(Links);

            }
            return result;

        }
        public static Link GetById(string id)
        {

            return Links.Where(x => x.Id == id).FirstOrDefault()!;
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

            link.Id = Guid.NewGuid().ToString();
            bool result = LinkValidation(link);


            var changeControl = true;

            if (!result)
            {
                Links.Add(old);
                return false;
            }

            Links.Add(link);

            WriteFile(Links);

            return true;


        }
        public static void UpdateAll() => WriteFile(Links);

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

            return linksResult.Count != 0 ? linksResult.DistinctBy(x => x.Id).ToList() : linksResult;

        }
        private static bool LinkValidation(Link link, bool sendFromApi = false)
        {
            var con1 = !Links.Any(x => x.Content.ToLower().Trim() == link.Content.ToLower().Trim());
            //var con2 = !Links.Any(x => x.Header == link.Header);
            var con3 = link.Categories.Count != 0;
            //var result = con1 && con2 && con3;
            var result = con1 && con3;

            var message = string.Empty;
            if (!con1)
                message += "This link is already registered!" + Environment.NewLine;
            //if (!con2)
            //    message +=  "This header is already registered!" +Environment.NewLine;
            if (!con3)
                message += "record must contain at least one category";

            if (!result)
            {

                if (!sendFromApi)
                    MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
            return result;
        }
        private static List<Link> ReadFile()
         => JsonSerializer.Deserialize<List<Link>>(File.ReadAllText(LinksPath))!;
        private static void WriteFile(List<Link> data)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(LinksPath, JsonSerializer.Serialize(data, options));
        }

    }

}
