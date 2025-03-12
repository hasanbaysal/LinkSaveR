using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;

namespace HB.LinkSaver.DataAcces
{
    public static class CategoryManager
    {
        private const string CategoriesPath = "categories.json";
        private static List<Category> _categories = new();
        public static List<Category> Categories
        {
            get
            {
                Load();
                return _categories;
            }
        }

        public static bool AddCategoryIntoGroup(string categoryGroupName, string categoryName)
        {
            Load();
            var data = _categories.Where(x => x.CategorGroupName == categoryGroupName).FirstOrDefault();

            if (data == null)
                return false;

            var res = data.SubCategories.Any(x => x == categoryName);
            if (res)
                return false;

            var generalList = _categories.SelectMany(x => x.SubCategories).ToList();

            // a category must be unique
            if (generalList.Contains(categoryName))
                return false;

            data.SubCategories.Add(categoryName);


            WriteFile();
            return true;
        }
        public static bool AddGroup(string groupName)
        {


            var res = _categories.Any(x => x.CategorGroupName == groupName);
            if (res)
                return false;

            _categories.Add(new Category() { CategorGroupName = groupName });

            WriteFile();
            return true;

        }

        /// <summary>
        /// if there is a record that related with the categoryName you cannot delete it
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public static bool Delete(string categoryName)
        {

            var result = LinkManager.Links.Where(x => x.Categories.Contains(categoryName)).Any();
            if (result) return false;


            var res = _categories.Where(x => x.SubCategories.Contains(categoryName)).FirstOrDefault();
            if (res == null)
                return false;


            res.SubCategories.Remove(categoryName);

            WriteFile();
            Load();
            return true;

        }
        /// <summary>
        /// if there is a record that related with the any elements of the CategoryGroup in linkData Records you cannot delete it
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public static bool DeleteGroup(string groupName)
        {
            if (groupName == Program.AllCategoryGroup)
                return false;

            var group = _categories.Where(x => x.CategorGroupName == groupName).FirstOrDefault();
            if (group == null) return false;


            var relatedExistControl = LinkManager.Links.Where(x => x.Categories.Any(x => group.SubCategories.Contains(x))).Any();
            if (relatedExistControl) return false;

            var data = _categories.Where(x => x.CategorGroupName == groupName).FirstOrDefault();

            _categories.Remove(data!);
            WriteFile();

            return true;
        }
        public static bool Update(string oldCategory, string newCategory)
        {


            var controlExist = _categories.Where(x => x.SubCategories.Contains(newCategory)).Any();
            if (controlExist) return false;


            var oldExistControl = _categories.Where(x => x.SubCategories.Contains(oldCategory)).Any();
            if (!oldExistControl) return false;





            for (int i = 0; i < LinkManager.Links.Count; i++)
            {
                var temp = LinkManager.Links[i].Categories;
                for (int j = 0; j < temp.Count; j++)
                {
                    if (temp[j].ToLower() == oldCategory.ToLower())
                    {
                        temp[j] = newCategory;
                    }
                }
            }


            var category = _categories.Where(x => x.SubCategories.Contains(oldCategory)).FirstOrDefault();


            category!.SubCategories.Remove(oldCategory);
            category!.SubCategories.Add(newCategory);

            WriteFile();
            LinkManager.UpdateAll();

            return true;
        }
        public static bool UpdateGroupName(string oldCategoryGroupName, string newCategoryGroupName)
        {

            var data = _categories.Where(x => x.CategorGroupName == oldCategoryGroupName).FirstOrDefault();
            if (data == null)
                return false;

            var newNameExistControl = _categories.Any(x => x.CategorGroupName == newCategoryGroupName);

            if (newNameExistControl)
                return false;


            data.CategorGroupName = newCategoryGroupName;

            WriteFile();
            return true;
        }

        public static List<string> GetAllCategoryGroupNames() => _categories.Select(x => x.CategorGroupName).ToList();
        public static List<string> GetAllCategoryNames() => _categories.SelectMany(x => x.SubCategories).ToList();
        public static List<string> GetAllCateriesByGroupName(string groupName)
        { 
            
            if(groupName == Program.AllCategoryGroup )
            {
                return GetAllCategoryNames();
            }

            return _categories.Where(x => x.CategorGroupName == groupName).FirstOrDefault()!.SubCategories; 
        
        }
        private static List<Category> ReadFile()
          => JsonSerializer.Deserialize<List<Category>>(File.ReadAllText(CategoriesPath))!;
        private static void WriteFile()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(CategoriesPath, JsonSerializer.Serialize(_categories, options: options));
        }
        private static void Load() => _categories = ReadFile();
    }

}
